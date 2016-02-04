using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public int speed;
    public Object projectile;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, new Vector2(transform.position.x, transform.position.y + 0.5f), transform.rotation) as Rigidbody;
            //clone.velocity = transform.TransformDirection(Vector3.forward * 10);

            //clone.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.position.x, transform.position.y + speed);

            //new Vector2(transform.position.x, transform.position.y + 1)
        }
    
}
}
