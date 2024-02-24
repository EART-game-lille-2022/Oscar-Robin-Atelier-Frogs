using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPlatform : MonoBehaviour
{
    public GameObject objectToShake;
    public float shakeMagnitude = 0.1f;
    public float shakeDuration = 2f;
    private Vector3 initialPosition;
    private float shakeTimer = 0f;
    private void Start() 
    {
        initialPosition = objectToShake.transform.position;
    }
    private void Update() 
    {
        if(shakeTimer > 0)
        {
            objectToShake.transform.position = initialPosition + Random.insideUnitSphere * shakeMagnitude;
            shakeTimer -= Time.deltaTime;
        }
        else
        {
            shakeTimer = 0f;
            objectToShake.transform.position = initialPosition;
            
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            StartShake();   
        }
    }
    public void StartShake()
    {
        shakeTimer = shakeDuration;
        Destroy(objectToShake, shakeDuration);
    }
}
