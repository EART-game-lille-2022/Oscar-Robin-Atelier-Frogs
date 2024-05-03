using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFrogs : MonoBehaviour
{
    private Animator _frogAnimator;

    private void Start() {
        _frogAnimator = GetComponent<Animator>();
    }

    public void StartjumpAnimation() {
        StartCoroutine(JumpAnimation());
    }

    IEnumerator JumpAnimation() {
        _frogAnimator.SetBool("jump", true);
        yield return new WaitForSeconds(1f);
        _frogAnimator.SetBool("jump", false);
    }
}
