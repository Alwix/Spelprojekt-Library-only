using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PausScript : MonoBehaviour
{
    public GameObject PausMenu;
    private bool paused = false;

    // Use this for initialization
    void Start()
    {
        PausMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }

        if(paused)
        {
            PausMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PausMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        paused = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(name);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(name);
    }
    public void Quit()
    {
        Application.Quit();
    }


}
