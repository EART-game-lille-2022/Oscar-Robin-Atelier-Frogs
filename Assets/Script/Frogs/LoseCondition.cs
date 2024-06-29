using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCondition : MonoBehaviour
{
    public GameObject player;
    public string NameScene;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
           SceneManager.LoadScene(NameScene);
        }
    }
}
