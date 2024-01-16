using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject start;
    [SerializeField] private GameObject over;

    void Start()
    {
        Time.timeScale = 0;
        GetComponent<Spawn>().enabled = false;
    }

    private void Update()
    {
        if (start.active == true)
        {
            if (Input.GetMouseButton(0))
            {
                StartGame();
            }
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        start.active = false;
        GetComponent<Spawn>().enabled = true;

    }

    public void GameOver()
    {
        Time.timeScale = 0;
        over.active = true;
    }

    public void PlayAgain()
    {
        var currentScene = SceneManager.GetActiveScene();
        var currentSceneName = currentScene.name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
