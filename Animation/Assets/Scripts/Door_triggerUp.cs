using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_triggerUp : MonoBehaviour
{
    public Animator AnimDoor;

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            AnimDoor.Play("DoorUpAnim");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            AnimDoor.Play("DoorUpAnimNegative");
        }
    }
}
