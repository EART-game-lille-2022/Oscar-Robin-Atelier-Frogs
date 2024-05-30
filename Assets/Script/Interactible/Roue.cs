using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Roue : MonoBehaviour
{
    public GameObject wheel;
    private void Start()
    {
        startPos = transform.localPosition;
        lastPos = transform.position;
        
        StartCoroutine(TurnObject());
        // Invoke("AfterTween", 2);
        // AfterTween();
    }
    public IEnumerator TurnObject()
    {
        yield return new WaitForSeconds(1.5f);
        TurnWheel();
        Debug.Log("rotation");
        StartCoroutine(TurnObject());

    }
    public void TurnWheel()
    {
        wheel.transform.DORotate (new Vector3(0f, wheel.transform.eulerAngles.y + 90f,0f), (0.5f), RotateMode.FastBeyond360);
    }
     public float speed = 5;
    public List<Rigidbody> bodiesOnMe;
    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log(other);
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if(bo == null) bo = other.GetComponentInParent<Rigidbody>();

        // if(bo && !bodiesOnMe.Contains(bo)) bodiesOnMe.Add(bo);
        // // healthPlayer.Death();
        // HealthPlayer.instance.Death();

    }
    private void OnTriggerExit(Collider other) 
    {
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if(bo == null) bo = other.GetComponentInParent<Rigidbody>();
        if(bo && bodiesOnMe.Contains(bo)) bodiesOnMe.Remove(bo);
    }
    Vector3 startPos;
    // void AfterTween() {
    //     transform.position = startPos;
    //     transform.DOMoveX(-20f, 5f).OnComplete(AfterTween);
    // }
    Vector3 lastPos;
    private void FixedUpdate() 
    {
        // transform.position += -transform.right * speed * Time.fixedDeltaTime;
        Vector3 delta = transform.position;
        foreach(var body in bodiesOnMe) 
        {
            body.position += delta;
        }
        lastPos = transform.position;
    }
}
