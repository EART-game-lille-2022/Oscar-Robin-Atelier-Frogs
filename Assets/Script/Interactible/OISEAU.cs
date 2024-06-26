using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OISEAU : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public float jumpHeight = 8f;
    public float jumpDuration = 1.5f;
    public float jumpForce = 200000f;
    public AnimationCurve jump;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            target.transform.localEulerAngles = new Vector3(target.transform.rotation.x, target.transform.rotation.y, target.transform.rotation.z);
            Debug.Log("Jump Oiseau");
            player.transform.DOJump(new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z+ jumpForce), jumpHeight, 1, jumpDuration).SetEase(jump).Play();
        }
    }

}
