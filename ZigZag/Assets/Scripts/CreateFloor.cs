using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFloor : MonoBehaviour
{
    [SerializeField]
    private GameObject floor;
    [SerializeField]
    private float sizeXZ;
    [SerializeField]
    private Vector3 lastPos;


    // Start is called before the first frame update
    void Start()
    {
        lastPos = floor.transform.position;
        sizeXZ = floor.transform.localScale.x;


        StartCoroutine(createFloorInGame());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createX()
    {
        Vector3 tempPos = lastPos;
        tempPos.x += sizeXZ;
        lastPos = tempPos;
        Instantiate(floor, tempPos, Quaternion.identity);
    }

    void createZ()
    {
        Vector3 tempPos = lastPos;
        tempPos.z += sizeXZ;
        lastPos = tempPos;
        Instantiate(floor, tempPos, Quaternion.identity);
    }

    void createXZ()
    {
        int temp = Random.Range(0, 10);

        if (temp < 5)
        {
            createX();
        }
        else if (temp >= 5)
        {
            createZ();
        }
    }

    IEnumerator createFloorInGame()
    {
        while (BallControler.gameOver != true)
        {
            yield return new WaitForSeconds(0.32f);
            createXZ();
        }
    }
}
