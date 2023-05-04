using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axes : MonoBehaviour
{
    public float vel = 5.0f;
    public float rotVel = 15.5f;

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * vel;
        float rotation = Input.GetAxis("Horizontal") * rotVel;

        move *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Rotate(0, rotation, 0);
        transform.Translate(0, 0, move);
    }
}
