using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    private void Update() 
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 10, player.transform.position.z -8);
    }
    private void Start() 
    {
        transform.Rotate(30,0,0);
    }
    
}
