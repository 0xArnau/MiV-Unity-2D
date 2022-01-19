using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControls : MonoBehaviour
{
    int numberOfLevels = 4;

    public void NextLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % (numberOfLevels));
    }

    public void BackLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + (numberOfLevels - 1)) % (numberOfLevels));
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
