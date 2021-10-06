using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerA : MonoBehaviour
{
    public float moveSpeed = 5f;    // Start is called before the first frame update
    public static Vector2 position;

    void Start()
    {
        position=transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        // movement range 
        float x = 0, y = 0;
        var moveStep = moveSpeed * Time.deltaTime;
        var viewPos = Camera.main.WorldToViewportPoint(position);
        if(Input.GetKey(KeyCode.UpArrow))
        {
            if(viewPos.y<1f)
            {
                y += moveStep;
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if(viewPos.y>0)
            {
                y -= moveStep;
            }         
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if(viewPos.x<1f)
            {
                x += moveStep;
            }          
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(viewPos.x>0)
            {
                x -= moveStep;
            }           
        }
        transform.Translate(new Vector2(x,y),Space.Self);
        position=transform.transform.position;
    }      
}
