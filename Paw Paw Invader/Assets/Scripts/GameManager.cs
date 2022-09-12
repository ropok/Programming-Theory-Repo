using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static bool isPaused;
    [SerializeField] GameObject UIManager;

    public static GameManager Instance
    {
        get
        {
            if (_instance is null)
                Debug.LogError("Game Manager is NULL");
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
        ResumeGame();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GameOver()
    {
        UIManager.transform.Find("GameOver").gameObject.SetActive(true);
        Debug.Log("Game Over!");
        PauseGame();
    }

    public void LevelCompleted()
    {
        UIManager.transform.Find("LevelCompleted").gameObject.SetActive(true);
        Debug.Log("Congratulations! You Won!");
        PauseGame();
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
}
