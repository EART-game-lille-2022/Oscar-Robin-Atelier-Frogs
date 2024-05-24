using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;  

public class spiderDaftPunk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.DOLocalRotate (new Vector3  (transform.rotation.eulerAngles.x,transform.rotation.eulerAngles.y,transform.rotation.eulerAngles.z + 180f), 1);
    }
}
