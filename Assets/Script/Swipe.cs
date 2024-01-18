using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject Capsule; 
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    private void Update() 
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if(endTouchPosition.x < startTouchPosition.x)
            {
                Debug.Log("Right");
                Right();
            }

            if(endTouchPosition.x > startTouchPosition.x)
            {
                Debug.Log("Left");
                Left();
            }
        }
    }
    private void Left()
    {
        Capsule.transform.position = new Vector3(Capsule.transform.position.x +2, Capsule.transform.position.y, Capsule.transform.position.z);
    }
    private void Right()
    {
        Capsule.transform.position = new Vector3(Capsule.transform.position.x -2, Capsule.transform.position.y, Capsule.transform.position.z);
    }
}
