using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        Destroy(gameObject);
        if(coll.gameObject.tag=="PlayerA")
        {
            Scorekeeper.Instance.pickupCoinA();
        }
        else if(coll.gameObject.tag=="PlayerB")
        {
            Scorekeeper.Instance.pickupCoinB();
        }
    }
}
