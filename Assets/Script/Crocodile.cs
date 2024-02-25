using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Crocodile : MonoBehaviour
{
    public GameObject crocodilePos;
    private void Start()
    {
        transform.DOMoveX(crocodilePos.transform.position.x -20f, 3f);
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Le croco à mangé la potite grenouille");
        }
    }
}
