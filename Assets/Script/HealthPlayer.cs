using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthPlayer : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) 
   {
        if(other.CompareTag("Ennemy"))
        {
            Debug.Log("Death");
            transform.position = new Vector3(0f,1f,0f);
        }
   }
}
