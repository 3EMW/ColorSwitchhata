using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buton : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Loading");
        Time.timeScale = 1;
    }
}
