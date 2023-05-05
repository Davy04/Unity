using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float vel = 6;
    public float rotVel = 50;
    public float gravity = 20;
    public Vector3 moveDir = Vector3.zero;
    public CharacterController control;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (control.isGrounded)
        {
            moveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= vel;
        }

        moveDir.y -= gravity * Time.deltaTime;
        control.Move(moveDir * Time.deltaTime);

        //Rotation

        float rotation = Input.GetAxis("Horizontal") * rotVel;
        rotation *= Time.deltaTime;

        transform.Rotate(0, rotation, 0);

        if (control.isGrounded)
        {
            if (moveDir.z != 0)
            {
                anim.SetBool("stop", false);
                anim.SetBool("walking", true);
            }
            else
            {
                anim.SetBool("stop", true);
                anim.SetBool("walking", false);
            }
        }

    }
}
