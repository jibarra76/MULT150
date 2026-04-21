using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
	
	void OnTriggerEnter(Collider other) {
        Debug.Log("Entered: " + other.gameObject.name);
    }
	
	void OnTriggerExit(Collider other) {
        Debug.Log("Exited: " + other.gameObject.name);
    }
	
	void OnTriggerStay(Collider other) {
        Debug.Log("Inside: " + other.gameObject.name);
    }
}