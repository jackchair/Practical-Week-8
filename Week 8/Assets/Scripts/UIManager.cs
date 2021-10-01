using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    static private UIManager instance;
    static public UIManager Instance
    {
        get
        {
            if(instance == null)
            {
                Debug.LogError("There is no UIManager instance in the scene.");
            }
            return instance;
        }
    }

    public Text scoreText;
    public string scoreFormat = "Score: {0}";

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
<<<<<<< Updated upstream
        
=======

>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = string.Format(scoreFormat, Scorekeeper.Instance.Score);
    }
<<<<<<< Updated upstream
}
=======
}
>>>>>>> Stashed changes
