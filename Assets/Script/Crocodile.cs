using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Crocodile : MonoBehaviour
{
    private void Start()
    {
        gameObject.transform.DOMoveX(gameObject.transform.position.x -20f, 3f);
    }
}
