using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{

    [SerializeField]
    private float vel = 0.2f;
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    public static bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(vel, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallMov();
        }

        if (!Physics.Raycast(transform.position,Vector3.down,1))
        {
            gameOver = true;
            rb.useGravity = true;
        }

        if(gameOver)
        {
            print("caindo");
        }
    }

    void BallMov()
    {
        if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, vel);
        }
        else if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(vel, 0, 0);
        }
    }
}