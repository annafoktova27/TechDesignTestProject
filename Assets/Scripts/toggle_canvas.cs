using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_canvas : MonoBehaviour
{
    public Canvas canvas;
    private AudioSource audiosource;

    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        audiosource.Play();   
        canvas.enabled = !canvas.enabled;
    }
}
