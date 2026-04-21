using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCount = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    } 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BottomTrigger")
        {
            bounceCount++;
            Debug.Log("Bounce Count: " + bounceCount);
        }
    }
}
