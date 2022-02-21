using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Encapsulation
    public bool isGameActive { get; private set; }
    [SerializeField] private GameObject gameOver;
    private void Start()
    {
        isGameActive = true;
        gameOver.SetActive(false);
    }

    //Abstraction
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
