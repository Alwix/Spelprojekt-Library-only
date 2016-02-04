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
       

    }

}
