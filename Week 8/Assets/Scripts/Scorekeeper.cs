using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
  
    static private Scorekeeper instance;
    static public Scorekeeper Instance 
    {
        get 
        {
            if (instance == null)
            {
                Debug.LogError("There is no Scorekeeper instance in the scene.");
            }
            return instance;
        }
    }

    private int scoreA = 0;
    public int ScoreA 
    {
        get
        {
            return scoreA;
        }
        
    }

    private int scoreB = 0;
    public int ScoreB 
    {
        get
        {
            return scoreB;
        }
        
    }
    public int scorePerCoin = 10;

    private PlayerA playerA;
    private PlayerB playerB;
    void Awake()
    {
        if (instance != null) 
        {
            // destroy duplicates
            Destroy(gameObject);            
        }
        else 
        {
            instance = this;
        }        
    }

    void Start()
    {
        //scoreA = 0;
        //scoreB = 0;
        // find the player 
        playerA = FindObjectOfType<PlayerA>();
        playerB = FindObjectOfType<PlayerB>();
    }

    public void pickupCoinA()
    {
        scoreA += scorePerCoin;
    }

    public void pickupCoinB()
    {
        scoreB += scorePerCoin;
    }

}