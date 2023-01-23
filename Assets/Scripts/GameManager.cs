using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject playButton;

    public void EnablePlayButton()
    {
        Time.timeScale = 0;
        playButton.SetActive(true);
    }

    public void ReplayScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
