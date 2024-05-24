using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimBlockRepeat : MonoBehaviour
{
    public int count = 1;
    public float delay = 0;
    // public float delayPerIndex = 1;
    public float[] delaysPattern;
    // public Animator animator;
    public Animator[] animators;
    int prefabIndex;

    void Start() {
        if(animators.Length > 0) {
            AnimatorClipInfo info = animators[prefabIndex].GetCurrentAnimatorClipInfo(0)[0];
            animators[prefabIndex].Play(info.clip.name, -1, Mathf.Repeat(-delay / info.clip.length, 1));
            float d = delay;
            for(int i = 1; i < count; i++) {
                prefabIndex ++;
                if(prefabIndex >= animators.Length)
                    prefabIndex = 0;

                GameObject go = GameObject.Instantiate(animators[prefabIndex].gameObject, animators[prefabIndex].transform.position, animators[prefabIndex].transform.rotation, animators[prefabIndex].transform.parent);
                Animator a = go.GetComponent<Animator>();
                info = a.GetCurrentAnimatorClipInfo(0)[0];

                d += delaysPattern[i%delaysPattern.Length];
                a.Play(info.clip.name, -1, Mathf.Repeat( -d / info.clip.length, 1));
            }

        }
    }
}
