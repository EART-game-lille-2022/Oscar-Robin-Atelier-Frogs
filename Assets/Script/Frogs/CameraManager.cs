using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    private void Update() 
    {
        transform.position = new Vector3(player.transform.position.x,12, player.transform.position.z - 8);
    }
    private void Start() 
    {
        transform.Rotate(30,0,0);
    }
    
}
