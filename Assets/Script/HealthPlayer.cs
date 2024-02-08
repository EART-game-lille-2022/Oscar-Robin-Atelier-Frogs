using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) 
   {
        if(other.CompareTag("Ennemy"))
        {
            Debug.Log("Death");
        }
   }
}
