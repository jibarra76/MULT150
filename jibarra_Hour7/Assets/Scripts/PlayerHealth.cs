using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004f;

        float poisonDamage = 125.5f;

        Debug.Log( health ); 

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        health -= poisonDamage;

        Debug.Log( health );

        string saying = ("Player has been unalived!");

        Debug.Log( saying );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
