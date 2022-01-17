using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDamage : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
   {
    if (collision.transform.CompareTag("Player")) {
        Debug.Log("Player damaged");
        //Destroy(collision.gameObject);
        collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        //SceneManager.LoadScene("lvl1");
    }
   }
}
