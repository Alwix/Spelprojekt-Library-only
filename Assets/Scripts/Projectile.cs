using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    


    //public int speed;
    public Object projectile;
    public static float charge = 1f;

    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            charge -= 1f;
            print("charge: " + charge);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            charge += 1f;
            print("charge: " + charge);
        }
        charge = Mathf.Clamp(charge, 1f, 10f);

        if (Input.GetButtonDown("Fire1"))
        {
            //Old
            Rigidbody clone;
            if (GameObject.FindWithTag("Apple") == null)
            {
                clone = Instantiate(projectile, new Vector2(transform.position.x, transform.position.y + 0.3f), transform.rotation) as Rigidbody;
            }
        }




    }
}
