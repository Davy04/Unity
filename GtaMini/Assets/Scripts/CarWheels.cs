using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarWheels : MonoBehaviour
{
    public WheelCollider[] wCollider;
    public Transform[] wheels;
    private Vector3 wheelPosition;
    private Quaternion wheelRotation;

    public float torque, friction, brake, angle;

    private void Start()
    {
        for (int x = 0; x < wCollider.Length; x++)
        {
            wCollider[x].ConfigureVehicleSubsteps(1, 12, 15);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Wheels();
    }

    void FixedUpdate()
    {
        wCollider[0].steerAngle = angle * Input.GetAxis("Horizontal");
        wCollider[1].steerAngle = angle * Input.GetAxis("Horizontal");

        for (int x = 0;x < wCollider.Length; x++) {
            wCollider[x].motorTorque = Input.GetAxis("Vertical") * torque;
            wCollider[x].brakeTorque = (Input.GetKey(KeyCode.Space)) ? brake : friction - Mathf.Abs(Input.GetAxis("Vertical") * friction);
        }
    }

    void Wheels()
    {
        for (int x = 0; x < wCollider.Length; x++)
        {
            wCollider[x].GetWorldPose(out wheelPosition, out wheelRotation);
            wheels[x].transform.position = wheelPosition;
            wheels[x].transform.rotation = wheelRotation;

            wCollider[x].motorTorque = Input.GetAxis("Vertical")*torque;
            wCollider[x].brakeTorque = (Input.GetKey(KeyCode.Space)) ? brake: friction - Mathf.Abs(Input.GetAxis("Vertical") * friction);

            if (x < 2)
            {
                wCollider[x].steerAngle = Mathf.Lerp(wCollider[x].steerAngle, angle * Input.GetAxis("Horizontal"), Time.deltaTime * 10);
            }
        }
    }
}
