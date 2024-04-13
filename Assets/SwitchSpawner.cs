using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class SwitchSpawner : MonoBehaviour
{
    public GameObject Spawner;
    public GameObject platformSpawner;
    public GameObject crocodileSpawner;
    public SpawnPlatform spawnPlatform;
    public SpawnCrocodile spawnCrocodile;
    private float countdownTime = 5f;

    private void Update() 
    {
        platformSpawner.transform.position = Spawner.transform.position;
        crocodileSpawner.transform.position = Spawner.transform.position;
    }
    private void Start()
    {
        StartCoroutine(CallFunctions());
    }

    private IEnumerator CallFunctions()
    {
        while (true)
        {
            FunctionA();
            yield return new WaitForSeconds(5f);
            FunctionB();
            yield return new WaitForSeconds(5f);
        }
    }

    private void FunctionA()
    {
        spawnCrocodile.SpawnCrocodileObject();
    }

    private void FunctionB()
    {
        spawnPlatform.SpawnPlatformMove();
    }
}


