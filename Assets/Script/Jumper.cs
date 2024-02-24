using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    public GameObject capsule;
    public float jumpHeight = 8f;
    public float jumpDuration = 1.5f;
    public float jumpForce = 8f;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            capsule.transform.DOJump(new Vector3(capsule.transform.position.x, capsule.transform.position.y, capsule.transform.position.z+ jumpForce), jumpHeight, 1, jumpDuration);
        }
    }
}
