using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noot : MonoBehaviour
{
    public AudioClip sound;

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
