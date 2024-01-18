using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject Capsule; 
    private Vector3 startTouchPosition;
    private Vector3 endTouchPosition;

    private void Update() 
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if(endTouchPosition.x < startTouchPosition.x && endTouchPosition.y < startTouchPosition.y)
            {
                Debug.Log("Right");
                Right();
            }

            if(endTouchPosition.x > startTouchPosition.x && endTouchPosition.y < startTouchPosition.y)
            {
                Debug.Log("Left");
                Left();
            }
            if(endTouchPosition.y > startTouchPosition.y)
            {
                Up();
            }
        }
    }
    private void Left()
    {
        Capsule.transform.position = new Vector3(Capsule.transform.position.x +4, Capsule.transform.position.y, Capsule.transform.position.z);
    }
    private void Right()
    {
        Capsule.transform.position = new Vector3(Capsule.transform.position.x -4, Capsule.transform.position.y, Capsule.transform.position.z);
    }
    private void Up()
    {
        Debug.Log("UP");
        Capsule.transform.position = new Vector3 (Capsule.transform.position.x, Capsule.transform.position.y, Capsule.transform.position.z +4);
    }
}
