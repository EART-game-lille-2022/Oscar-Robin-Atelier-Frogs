using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlatformManager : MonoBehaviour
{   
    public float speed = 5;
    public List<Rigidbody> bodiesOnMe;
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other);
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if(bo == null) bo = other.GetComponentInParent<Rigidbody>();

        if(bo && !bodiesOnMe.Contains(bo)) bodiesOnMe.Add(bo);
    }
    private void OnTriggerExit(Collider other) 
    {
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if(bo == null) bo = other.GetComponentInParent<Rigidbody>();
        if(bo && bodiesOnMe.Contains(bo)) bodiesOnMe.Remove(bo);
    }
    Vector3 startPos;
    private void Start() 
    {
        startPos = transform.position;
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
        foreach(var body in bodiesOnMe) 
        {
            body.position += delta;
        }
        lastPos = transform.position;
    }
}
