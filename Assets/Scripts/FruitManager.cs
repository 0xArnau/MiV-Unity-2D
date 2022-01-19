using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FruitManager : MonoBehaviour
{

    public TMP_Text totalFruits;
    public TMP_Text fruitsCollected;

    private int totalFruitsInLevel;

    void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = (totalFruitsInLevel - transform.childCount).ToString();
    }
    
    public void AllFruitsCollected() 
    {
        if (transform.childCount < 1)
        {
            //Debug.Log("All fruits collected");
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 4);
        }
            
    }
}
