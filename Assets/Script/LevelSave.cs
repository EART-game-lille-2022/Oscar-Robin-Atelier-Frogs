using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxLevel = PlayerPrefs.GetInt("maxLevel", 1);
        PlayerPrefs.SetInt( "lastPlayedLevel", UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex );
        PlayerPrefs.SetInt( "maxLevel", Mathf.Max(maxLevel, UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex ));

        // transform.GetSiblingIndex(); //
    }
}
