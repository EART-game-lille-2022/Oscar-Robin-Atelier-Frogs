using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockRepeat : MonoBehaviour
{
    // public int count = 1;
    public float delay = 0;
    // public float delayPerIndex = 1;
    public float[] delaysPattern;
    // public Animator animator;
    public GameObject[] objects;
    int prefabIndex;

    int i;

    IEnumerator Start() {
        foreach (var obj in objects) { obj.SetActive(false); }

        if(objects.Length > 0) {
            // AnimatorClipInfo info = animators[prefabIndex].GetCurrentAnimatorClipInfo(0)[0];
            // animators[prefabIndex].Play(info.clip.name, -1, Mathf.Repeat(-delay / info.clip.length, 1));
            // float d = delay;
            yield return new WaitForSeconds( delay );
            while(true) {
            // for(int i = 1; i < count; i++) {
                prefabIndex ++;
                if(prefabIndex >= objects.Length)
                    prefabIndex = 0;

                GameObject go = GameObject.Instantiate(objects[prefabIndex].gameObject, objects[prefabIndex].transform.position, objects[prefabIndex].transform.rotation, objects[prefabIndex].transform.parent);
                go.SetActive(true);
                // GameObject go = GameObject.Instantiate(objects[prefabIndex].gameObject, objects[prefabIndex].transform.position, objects[prefabIndex].transform.rotation, transform);
                // Animator a = go.GetComponent<Animator>();
                // info = a.GetCurrentAnimatorClipInfo(0)[0];

                // d += delaysPattern[i%delaysPattern.Length];
                // a.Play(info.clip.name, -1, Mathf.Repeat( -d / info.clip.length, 1));

                yield return new WaitForSeconds( delaysPattern[i%delaysPattern.Length] );
                i++;
            }

        }
    }
}
