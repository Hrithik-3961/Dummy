using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int cherryCounter = 0;
    [SerializeField] private Text cherriesText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherryCounter++;
            cherriesText.text =  "Cherries: " + cherryCounter;
        }
    }
}
