using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PausScript : MonoBehaviour
{

    GameObject PauseMenu;
    bool paused;
    bool muted;
    [SerializeField]
    Text mutetext;


    // Use this for initialization
    void Start()
    {
        paused = false;
        PauseMenu = GameObject.Find("PauseMenu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
        }

    }

    public void Resume()
    {
        paused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }

    /*  public void Save()
      {
          PlayerPrefs.SetInt("currentscenesave", SceneManager.LoadScene());
      }
    */
    public void Load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
    }


}
