using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Swipe : MonoBehaviour
{
    public GameObject frogs;
    public GameObject Capsule; 
    public bool canJump = true;
    private Vector3 startTouchPosition;
    private Vector3 endTouchPosition;
    int touchID;
    [SerializeField] private UnityEvent _onJump;

    private void Update() 
    {
        if(Input.touchCount > 0 && touchID == -1 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
            touchID = Input.GetTouch(0).fingerId;
        }

        if(Input.touchCount > 0 && touchID == Input.GetTouch(0).fingerId && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Ended)
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

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q)|| Input.GetKeyDown(KeyCode.A)) Go(Vector3.left);
        if(Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D)) Go(Vector3.right);
        if(Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown(KeyCode.W)) Go(Vector3.forward);
        if(Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.S)) Go(Vector3.back);
    }
    public void Go(Vector3 direction) 
    {
        if(canJump == false)
        {
            return;
        }
        _onJump.Invoke();
        frogs.transform.LookAt(new Vector3(Capsule.transform.position.x + direction.x, Capsule.transform.position.y, Capsule.transform.position.z+  direction.z), Vector3.up);
        Capsule.transform.DOMove(Capsule.transform.position + direction * 4, 0.8f);
        canJump = false;
        StartCoroutine(cooldown());
    }
    public IEnumerator cooldown()
    {
        yield return new WaitForSeconds(2f);
        canJump = true;

    }
}
