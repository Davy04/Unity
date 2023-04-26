using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0, 0, Space.Self);
        transform.Rotate(Vector3.right * 0.09f, Space.World);
        transform.localScale += Vector3.forward * 0.05f;
    }
}
