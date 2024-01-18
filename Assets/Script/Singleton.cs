using UnityEngine;

public class Singleton<T> : MonoBehaviour
    where T : Component
{
    private static T _instance;
    // public static T Instance 
    // {
    //     // get 
    //     // {
    //     //     if(_instance == null)
    //     //     {
    //     //         var objs = FindObjectOfType (typeof(T)) as T[];
    //     //         if()
    //     //     }
    //     // }
    // }
    
}
