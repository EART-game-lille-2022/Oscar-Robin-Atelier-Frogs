using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlatformManager : MonoBehaviour
{
    public SpawnPlatform spawnPlatform;
    private void Start() 
    {
        transform.DOMoveX(-20f, 5f);
    }
    private void Update() 
    {
        if(transform.position.x <= -15f)
        {
            spawnPlatform.SpawnPlatformMove();
            Debug.Log("FinishRace");
        }
        if(transform.position.x == -20f)
        {
            Destroy(gameObject);
        }
    }
}
