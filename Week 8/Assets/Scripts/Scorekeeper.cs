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
            if(instance == null)
            {
                Debug.LogError("There is no Scorekeeper instance in the scene.");
            }
            return instance;
        }
    }

    private int score = 0;
    public int Score
    {
        get
        {
            return score;
        }
    }

    public int scorePerCoin = 10;

    private Player player;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pickupCoin()
    {
        score += scorePerCoin;
    }
}