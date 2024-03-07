using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBlockRepeat : MonoBehaviour
{
    public int count = 1;
    public float delay = 0;
    // public float delayPerIndex = 1;
    public float[] delaysPattern;
    public Animator animator;
    void Start() {
        if(animator) {
            AnimatorClipInfo info = animator.GetCurrentAnimatorClipInfo(0)[0];
            animator.Play(info.clip.name, -1, Mathf.Repeat(-delay / info.clip.length, 1));
            float d = delay;
            for(int i = 1; i < count; i++) {
                GameObject go = GameObject.Instantiate(animator.gameObject, animator.transform.position, animator.transform.rotation, animator.transform.parent);
                Animator a = go.GetComponent<Animator>();
                info = a.GetCurrentAnimatorClipInfo(0)[0];

                d += delaysPattern[i%delaysPattern.Length];
                a.Play(info.clip.name, -1, Mathf.Repeat( -d / info.clip.length, 1));
            }

        }
    }
}
