using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerfDist : MonoBehaviour
{
    public static bool look = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            look = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            look = false;
        }
    }
}
