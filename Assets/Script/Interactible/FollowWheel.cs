using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWheel : MonoBehaviour
{
    public float speed = 5;
    Vector3 startPos;
    Vector3 lastPos;
    public List<Rigidbody> bodiesOnMe;
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other);
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if(bo == null) bo = other.GetComponentInParent<Rigidbody>();

    }
    private void OnTriggerExit(Collider other) 
    {
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if(bo == null) bo = other.GetComponentInParent<Rigidbody>();
        if(bo && bodiesOnMe.Contains(bo)) bodiesOnMe.Remove(bo);
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
    private void Start() 
    {
        startPos = transform.localPosition;
        lastPos = transform.position;
    }
}
