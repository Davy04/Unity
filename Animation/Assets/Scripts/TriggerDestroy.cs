using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerDestroy : MonoBehaviour
{
    [SerializeField]
    private int itens = 0;
    [SerializeField]
    private Text Txt;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            itens += 1;
            Txt.text = itens.ToString();
        }
    }
}
