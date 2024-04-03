using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCrocodile : MonoBehaviour
{
    public GameObject crocodile;
    public float timeRemaining = 10f;
    public bool playerDead = false;
    public void SpawnCrocodileObject()
    {
        Destroy(Instantiate(crocodile, transform.position,transform.rotation), 5);
    }
    private void Update() 
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining <=0)
        {
            SpawnCrocodileObject();
            timeRemaining = 10f;
        }
    }
    public void ResetSpawnerCrocodile()
    {
        if(playerDead == true)
        {
            
        }
    }
}
