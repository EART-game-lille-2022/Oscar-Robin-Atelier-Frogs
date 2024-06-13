using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Roue : MonoBehaviour
{
    public GameObject wheel;
    public float speed = 5;
    public List<Rigidbody> bodiesOnMe = new List<Rigidbody>();

    private Vector3 startPos;
    private Vector3 lastPos;

    private void Start()
    {
        startPos = transform.localPosition;
        lastPos = transform.position;
        
        StartCoroutine(TurnObject());
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
        wheel.transform.DORotate(new Vector3(0f, wheel.transform.eulerAngles.y + 90f, 0f), 0.5f, RotateMode.FastBeyond360);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if (bo == null) bo = other.GetComponentInParent<Rigidbody>();

        if (bo && !bodiesOnMe.Contains(bo)) bodiesOnMe.Add(bo);
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody bo = other.GetComponent<Rigidbody>();
        if (bo == null) bo = other.GetComponentInParent<Rigidbody>();
        if (bo && bodiesOnMe.Contains(bo)) bodiesOnMe.Remove(bo);
    }

    private void FixedUpdate()
    {
        Vector3 delta = transform.position - lastPos;
        foreach (var body in bodiesOnMe)
        {
            body.position += delta;
        }
        lastPos = transform.position;
    }
}
