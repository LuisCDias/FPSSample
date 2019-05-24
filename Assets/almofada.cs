using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class almofada : MonoBehaviour
{
     // This Will Configure the  AudioSource Component; 
     // MAke Sure You added AudioSouce to death Zone;
     void Start ()   
     {
        
     }        
 
     private void OnTriggerEnter(Collider tetast)
     {
         GetComponent<AudioSource> ().Play ();
     }
}
