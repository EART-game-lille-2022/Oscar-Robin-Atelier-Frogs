using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlatformManager : MonoBehaviour
{   
    private void Start() 
    {
        transform.DOMoveX(-20f, 5f);
    }
    private void Update() 
    {
        if(transform.position.x == -20f)
        {
            Destroy(gameObject);
        }
    }
}
