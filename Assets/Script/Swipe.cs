using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject platform;
    public GameObject Capsule; 
    private Vector3 startTouchPosition;
    private Vector3 endTouchPosition;
    int touchID;
    private void Update() 
    {
        if(Input.touchCount > 0 && touchID == -1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
            touchID = Input.GetTouch(0).fingerId;
        }

        if(Input.touchCount > 0 && touchID == Input.GetTouch(0).fingerId && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchID = -1;
            endTouchPosition = Input.GetTouch(0).position;
            if(endTouchPosition.x < startTouchPosition.x && endTouchPosition.y < startTouchPosition.y)
            {
                Go(Vector3.left);
            }

            if(endTouchPosition.x > startTouchPosition.x && endTouchPosition.y < startTouchPosition.y)
            {
                Go(Vector3.right);
            }
            if(endTouchPosition.y > startTouchPosition.y)
            {
                Go(Vector3.forward);
            }
            
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow)) Go(Vector3.left);
        if(Input.GetKeyDown(KeyCode.RightArrow)) Go(Vector3.right);
        if(Input.GetKeyDown(KeyCode.UpArrow)) Go(Vector3.forward);
        if(Input.GetKeyDown(KeyCode.DownArrow)) Go(Vector3.back);
    }

    private void Go(Vector3 direction) 
    {
        Vector3 target = Capsule.transform.position + direction * 4;
        target.x = Mathf.Round(target.x);
        target.z = Mathf.Round(target.z);
        Capsule.transform.position = target;
    }
}
