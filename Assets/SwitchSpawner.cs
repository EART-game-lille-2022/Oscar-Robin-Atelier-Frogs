using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class SwitchSpawner : MonoBehaviour
{
    public Transform crocodileSpawnPosition;
    public Transform platformSpawnPosition;
    public SpawnPlatform spawnPlatform;
    public SpawnCrocodile spawnCrocodile;
    private float countdownTime = 5f;

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
        crocodileSpawnPosition.position = this.transform.position;
        spawnCrocodile.SpawnCrocodileObject();
    }

    private void FunctionB()
    {
        platformSpawnPosition.position = this.transform.position;
        spawnPlatform.SpawnPlatformMove();
    }
}


