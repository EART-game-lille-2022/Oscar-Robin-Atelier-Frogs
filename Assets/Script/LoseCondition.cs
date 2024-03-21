using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnPoint;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            player.transform.position = new Vector3(spawnPoint.transform.position.x,spawnPoint.transform.position.y + 1.5f, spawnPoint.transform.position.z);
        }
    }
}
