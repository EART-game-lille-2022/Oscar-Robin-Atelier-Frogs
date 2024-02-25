using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject movingPlatform;
    public float timeRemaining =1.5f;
    public void SpawnPlatformMove()
    {
        Destroy(Instantiate(movingPlatform, transform.position, transform.rotation), 5);          
    }
    private void Update() 
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining <=0)
        {
            SpawnPlatformMove();
            timeRemaining = 1.5f;
        }
    }
    
}
