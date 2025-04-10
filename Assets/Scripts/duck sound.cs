using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducksound : MonoBehaviour
{
    void start()
    {
        
    }

    public void selected()
    {
        AudioSource source = GetComponent <AudioSource>();
        Debug.Log("duck selected");
        source.Play();
    }
}
