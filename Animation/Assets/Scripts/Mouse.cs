using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            print("LC");
        }

        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            print("RC");
        }

        if (Input.GetKeyUp(KeyCode.Mouse2))
        {
            print("MC");
        }
    }
}
