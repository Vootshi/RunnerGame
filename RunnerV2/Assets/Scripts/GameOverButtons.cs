using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverButtons : MonoBehaviour
{
    public Player player;
    public GameObject gameOverScreen;
    public GameObject tapToStart;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void ContinueGame()
    {
        gameOverScreen.SetActive(false);
        tapToStart.SetActive(true);
        player.Disable();

        //Need to add ads
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings);
    }
}
