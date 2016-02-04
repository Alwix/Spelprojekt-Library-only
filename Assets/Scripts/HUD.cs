using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] EnergySprites;
    public Image EnergyUI;
    public Player player;
    

    void start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponents<Player>();

    }

    void Update()
    {

    }
}