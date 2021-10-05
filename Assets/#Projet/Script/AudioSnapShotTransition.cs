using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class AudioSnapShotTransition : MonoBehaviour
{
    public AudioMixerSnapshot snapshot;
    public float transitionTime;

    
    void OnMouseDown() 
    {
        snapshot.TransitionTo(transitionTime);
    }
    
}
