using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Click_Music : MonoBehaviour
{
    public AudioSource audiodata;

    void OnMouseDown() {
        audiodata.Play();
    }


}
