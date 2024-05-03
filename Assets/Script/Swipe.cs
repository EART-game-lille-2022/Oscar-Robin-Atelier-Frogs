using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class Swipe : MonoBehaviour
{
    public GameObject Capsule; 
    public bool canJump = true;
    private Vector3 startTouchPosition;
    private Vector3 endTouchPosition;
    int touchID;
    [SerializeField] private UnityEvent _onJump;

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
    public void Go(Vector3 direction) 
    {
        if(canJump == false)
        {
            return;
        }
        _onJump.Invoke();
        // Vector3 target = Capsule.transform.position + direction * 4;
        Capsule.transform.DOMove(Capsule.transform.position + direction * 4, 1f);
        // target.x = Mathf.Round(target.x);
        // target.z = Mathf.Round(target.z);
        // Capsule.transform.position = target;
        canJump = false;
        StartCoroutine(cooldown());
        //Call Coroutine Here
    }
    public IEnumerator cooldown()
    {
        yield return new WaitForSeconds(1f);
        canJump = true;

    }
}
