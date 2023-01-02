using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionRadius : MonoBehaviour
{
    public bool inRange = false;
    private void OnTriggerStay2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            // Debug.Log("IN RANGE");
            inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            // Debug.Log("NOT IN RANGE");
            inRange = false;
        }
    }
}
