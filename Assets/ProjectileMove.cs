using UnityEngine;
using System.Collections;

public class ProjectileMove : MonoBehaviour
{
    public int speed;
    //public Object thisProjectile;
    private bool travelToTarget = true;
    public bool rotateToTarget;
    private Vector2 target = new Vector2(0, 0);
    public int travelSpeed;
    private Vector2 direction;
    private float charge = Projectile.charge;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Använd transform istället för velocity!!!
        //GetComponent<Transform>().position = new Vector2(transform.position.x, transform.position.y * speed);


        //GetComponent<Rigidbody2D>().velocity = new Vector2(transform.position.x, transform.position.y * speed);

        //GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed);

        //Destroy apples after 3 seconds
        Destroy(gameObject, 3);
        

        if (GameObject.FindWithTag("Apple") == null)
        { travelToTarget = true; }

        if (Input.GetMouseButtonDown(0) && travelToTarget)
        {
            var mouseClick = Input.mousePosition;
            target = Camera.main.ScreenToWorldPoint(mouseClick);
            //rotateToTarget = false;
            travelToTarget = false;
            //print("NEW TARGET: " + target);
            //Debug.DrawLine(Camera.main.transform.position, target, Color.red, 10f);
            direction = (new Vector2(target.x, target.y) - new Vector2(gameObject.transform.position.x, gameObject.transform.position.y)).normalized;
            GetComponent<Rigidbody2D>().velocity = (direction * travelSpeed) * charge;
            //gameObject.GetComponent<Rigidbody2D>().AddForce(direction * travelSpeed);
        }

        if (travelToTarget)
        {
            var distanceToTarget = Vector2.Distance(gameObject.transform.position, target);

            if (distanceToTarget > 2)
            {

                //print("Distance: " + distanceToTarget);
                //gameObject.GetComponent<Rigidbody2D>().AddForce(direction * travelSpeed);
                //GetComponent<Rigidbody2D>().velocity = direction * travelSpeed;
            }
            else
            {
                travelToTarget = false;
                //print("travelling COMPLETE");
            }
        }
    }
}
