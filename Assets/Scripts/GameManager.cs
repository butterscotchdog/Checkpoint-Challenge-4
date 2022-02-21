using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    [SerializeField] private GameObject gameOver;
    private void Start()
    {
        isGameActive = true;
        gameOver.SetActive(false);
    }

    public void EndGame()
    {
        isGameActive = false;
        gameOver.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
