using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            Debug.Log("ButtonTrigger");
            Transparent.require = true;
        }
    }
}
