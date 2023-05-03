using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("subiu");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("desceu");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("apertou");
        }
    }
}
