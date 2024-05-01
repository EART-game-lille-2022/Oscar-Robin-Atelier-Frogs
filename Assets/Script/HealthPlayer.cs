using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthPlayer : MonoBehaviour
{
    public static HealthPlayer instance;
    private void Awake() {
        instance = this;
    }
    
   private void OnTriggerEnter(Collider other) 
   {
        if(other.CompareTag("Ennemy"))
        {
            Death();
        }
   }
   public void Death()
   {
        Debug.Log("Death");
        transform.position = new Vector3(0f,1f,0f);
   }
}
