using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCrosshair : MonoBehaviour
{
    private Canvas canvasObject;

    void Start()
    {
        canvasObject = GetComponent<Canvas>();
        canvasObject.enabled = false;
    }


    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            canvasObject.enabled = true;
        }
        else
        {
            canvasObject.enabled = false;
        }
    }
}
