using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_canvas : MonoBehaviour
{
    public Canvas canvas;

    private void OnMouseDown()
    {
        canvas.enabled = !canvas.enabled;
    }
}
