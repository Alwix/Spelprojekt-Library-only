using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerUI : MonoBehaviour
{


    // Stats
    public int currentEnergy; 
    public int maxEnergy = 100;

    // Use this for initialization
    void Start()
    {
        currentEnergy = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentEnergy > maxEnergy)
        {
            currentEnergy = maxEnergy;
        }
        if (currentEnergy < 0)
        {
            Death();
        }

    }

    void Death() // Detta händer när man dör, restart
    {
        // restart after Death
        SceneManager.LoadScene(1);
    }

}

