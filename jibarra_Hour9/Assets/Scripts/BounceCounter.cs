using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
private int bounceCount = 0;
private void OnCollisionEnter(Collision collision)
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }    
    {
        // I can't figure this out professor!! :(
        if (collision.gameObject.name == "BottomTrigger")
        {
            bounceCount++;
            Debug.Log("Bounce Count: " + bounceCount);
        }
    }
}
