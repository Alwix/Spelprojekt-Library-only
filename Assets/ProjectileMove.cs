using UnityEngine;
using System.Collections;

public class ProjectileMove : MonoBehaviour {
    public int speed;
    //public Object thisProjectile;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        // Använd transform istället för velocity!!!
        //GetComponent<Transform>().position = new Vector2(transform.position.x, transform.position.y * speed);
        
        
        //GetComponent<Rigidbody2D>().velocity = new Vector2(transform.position.x, transform.position.y * speed);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * speed);


    }
}
