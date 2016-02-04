using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<ProjectileMove> projectileList = null;
    public ProjectileMove currentProjectile = null;

    public Rect guiAreaRect = new Rect(0, 0, 0, 0);

    void OnGUI()
    {
        GUILayout.BeginArea(guiAreaRect);
        GUILayout.BeginVertical();

        foreach (ProjectileMove projectile in projectileList)
        {
            if (projectile != null)
            {
                if (GUILayout.Button(projectile.projectileLogo, GUILayout.Width(50), GUILayout.Height(50)))
                {
                    currentProjectile = projectile;
                    Debug.Log(currentProjectile);
                }
            }
        }
        GUILayout.EndVertical();
        GUILayout.EndArea();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
