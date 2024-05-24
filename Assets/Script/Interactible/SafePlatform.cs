using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafePlatform : MonoBehaviour
{
    public GameObject Player;
    public GameObject resetPosition;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Player.transform.position = new Vector3(resetPosition.transform.position.x, resetPosition.transform.position.y + 1.5f, resetPosition.transform.position.z);
            Debug.Log(Player.transform.position);
        }
    }
}
