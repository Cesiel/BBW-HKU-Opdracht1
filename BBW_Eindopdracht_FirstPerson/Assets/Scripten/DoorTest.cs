using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTest : MonoBehaviour
{
    public Animation hingehere;

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            hingehere.Play();
    }
}
