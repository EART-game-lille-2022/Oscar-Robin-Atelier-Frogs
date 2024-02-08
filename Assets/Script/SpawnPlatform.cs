using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject movingPlatform;
    private void Start() 
    {   
        SpawnPlatformMove();
    }
    public void SpawnPlatformMove()
    {
        Instantiate(movingPlatform, new Vector3(10f, 0f, 13f), Quaternion.identity);        
        Debug.Log("SpawnPlatform");
    }
}
