using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class ScaleTwin : MonoBehaviour
{
    public void OnClose()
    {
        transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
    public void DestroyMe()
    {
        Destroy(gameObject);
    }
}
