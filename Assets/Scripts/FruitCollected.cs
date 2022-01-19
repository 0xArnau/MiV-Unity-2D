using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            GetComponent<SpriteRenderer>().enabled = false;
            for(int i = 0; i < gameObject.transform.childCount; i++)
            {
                gameObject.transform.GetChild(i).gameObject.SetActive(true);
            }

            //FindObjectOfType<FruitManager>().AllFruitsCollected();

            Destroy(gameObject, .5f);
        }
    }
}
