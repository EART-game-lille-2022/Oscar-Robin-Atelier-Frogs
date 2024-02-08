using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject movingPlatform;
    public float timeRemaining =1.5f;
    public void SpawnPlatformMove()
    {
        Instantiate(movingPlatform, new Vector3(13f, -0.5f, 12f), Quaternion.identity);        
        Debug.Log("SpawnPlatform");
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
