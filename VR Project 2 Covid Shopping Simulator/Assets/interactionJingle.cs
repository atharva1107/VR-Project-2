using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionJingle : MonoBehaviour
{
    [SerializeField]
    public AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
            audio.Play();
    }

}
