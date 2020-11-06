using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PullNegativity : MonoBehaviour
{
    private bool pulling = false;

    public AudioListVariable PullAudio;
    public LayerVariable IntersectLayer;

    private AudioSource myAudioSource;

    private void Awake() {
        myAudioSource = GetComponent<AudioSource>();
    }

    private void Update() {
        if (pulling) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, IntersectLayer.Value)) {
                transform.position = hit.point;
            }
        }
    }

    public void StartPull() {
        Debug.Log("Pull started!");
        int nr = Random.Range(0, PullAudio.Values.Count);
        myAudioSource.clip = PullAudio.Values[nr];
        myAudioSource.Play();
        pulling = true;
    }

    public void ReleasePull() {
        Debug.Log("Pull ended!");
        myAudioSource.Stop();
        pulling = false;
    }
}
