using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WallManager : MonoBehaviour
{
    public float speed = 5;
    Vector3 startPos;
    private void Start() 
    {
        startPos = transform.localPosition;
        lastPos = transform.position;
        
        // transform.DOMoveX(-20f, 5f);
        // Invoke("AfterTween", 2);
        // AfterTween();
    }
    void AfterTween() {
        transform.position = startPos;
        transform.DOMoveX(-20f, 5f).OnComplete(AfterTween);
    }
    Vector3 lastPos;
    private void Update() 
    {
        if(transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate() 
    {
        transform.position += -transform.right * speed * Time.fixedDeltaTime;
        Vector3 delta = transform.position - lastPos;
        lastPos = transform.position;
    }
}
