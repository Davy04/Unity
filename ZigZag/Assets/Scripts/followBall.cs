using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followBall : MonoBehaviour
{

    [SerializeField]
    private Transform ball;
    [SerializeField]
    private Vector3 dist;
    [SerializeField]
    private float lerpVal;
    [SerializeField]
    private Vector3 pos, targetPos;


    // Start is called before the first frame update
    void Start()
    {
        dist = ball.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (!BallControler.gameOver)
        {
            followFunc();
        }
        
    }

    void followFunc()
    {
        pos = transform.position;
        targetPos = ball.position - dist;
        pos = Vector3.Lerp(pos, targetPos, lerpVal);
        transform.position = pos;
    }
}
