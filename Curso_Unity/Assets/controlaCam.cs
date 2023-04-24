using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlaCam : MonoBehaviour
{
    public Camera[] cam;


    // Start is called before the first frame update
    void Start()
    {
        cam[0].enabled = true;
        cam[1].enabled = false;
        cam[2].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            cam[0].enabled = true;
            cam[1].enabled = false;
            cam[2].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            cam[0].enabled = false;
            cam[1].enabled = true;
            cam[2].enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            cam[0].enabled = false;
            cam[1].enabled = false;
            cam[2].enabled = true;
        }
    }
}
