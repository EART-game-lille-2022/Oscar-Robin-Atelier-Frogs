using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
   private void OnColliderEnter(Collision other) 
   {
        if(other.gameObject.CompareTag("Ennemy"))
        {
            Debug.Log("Death");
        }
   }
}
