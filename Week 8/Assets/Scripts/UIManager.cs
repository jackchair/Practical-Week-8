using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
  
    // Singleton
    static private UIManager instance;
    static public UIManager Instance 
    {
        get 
        {
            if (instance == null) 
            {
                Debug.LogError("There is not UIManager in the scene.");
            }            
            return instance;
        }
    }

    public Text scoreTextA;
    public Text scoreTextB;
    public string scoreFormat = "Score: {0}";

    void Awake() 
    {
        if (instance != null)
        {
            // there is already a UIManager in the scene, destory this one
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
    }

    void Update()
    {
        scoreTextA.text = string.Format(scoreFormat, Scorekeeper.Instance.ScoreA); 
        scoreTextB.text = string.Format(scoreFormat, Scorekeeper.Instance.ScoreB);   
    }

}