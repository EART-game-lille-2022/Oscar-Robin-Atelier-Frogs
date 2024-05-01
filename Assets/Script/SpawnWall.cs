using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWall : MonoBehaviour
{
    public GameObject wall;
    public float timeRemaining =1.5f;
    public void SpawnWallObastacle()
    {
        Destroy(Instantiate(wall, transform.position, transform.rotation), 5);          
    }
    private void Update() 
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        if(timeRemaining <=0)
        {
            SpawnWallObastacle();
            timeRemaining = 1.5f;
        }
    }
}
