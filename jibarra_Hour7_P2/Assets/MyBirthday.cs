using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for ( int days = 1; days <= 31; days++ )
        if (days == 7)
            {
                Debug.Log("It's my birthday!");
            }
        else 
            {
                Debug.Log( days );
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
