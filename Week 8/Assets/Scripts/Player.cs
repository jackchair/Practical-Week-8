using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed=5;    
    public static Vector3 position;        
    private MeshRenderer sprite;       
    private Vector3 worldPosLeftBottom;   
    private Vector3 worldPosTopRight;      
    public static Player instance;
    // Start is called before the first frame update
    void Start()
    {
        position=transform.position;
        instance = this;
        sprite = GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>();
        worldPosLeftBottom = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        worldPosTopRight = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
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
        LimitPosition(transform);
        position=transform.transform.position;
    }
    void LimitPosition(Transform transform)
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, worldPosLeftBottom.x+sprite.bounds.extents.x, worldPosTopRight.x-sprite.bounds.extents.x),
        Mathf.Clamp(transform.position.y, worldPosLeftBottom.y+sprite.bounds.extents.y, worldPosTopRight.y-sprite.bounds.extents.y));
    }    
}
