using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koi : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 1;
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;

    private bool move;

    private int counter;
    public int numoffish; 

    //SOUND 
    public AudioSource clicksound;


    public Vector3 position; 


    // Use this for initialization
    void Start()
    {
        counter = 0; 
        move = true; 
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        if (move == true)
        {

            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
                timeLeft += accelerationTime;
            }

        }
       
    }
    
    void FixedUpdate()
    {
        if (move == true) {

            rb.AddForce(movement * maxSpeed);
        }
           
    }

    //For click and drag 
    /*
    private void OnMouseDown()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos); 
    }*/
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)){
            counter++;
            if (counter < numoffish)
            {
                // Whatever you want it to do.
                //SOUND 
                clicksound.Play();

                // gameObjectToMove.transform.position = new Vector3(x, y, z);
                //gameObject.transform.position = new Vector3(7, 1, 0); //This works! 
                gameObject.transform.position = position;
                move = false;

                //DESTROY 
                // Destroy(gameObject);


            }
            else if (counter >= numoffish) {
                Debug.Log("Got all the fish");
                //GetComponent<Rigidbody>().enabled = false;
                //  Rigidbody rigidbody = GetComponent<Rigidbody>();

                //  GetComponent<Rigidbody>().enabled = false;
                //  rigidbody.enabled = false;

                rb.isKinematic = true;
                /*
                Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
                rigidbody.isKinematic = true; */
            }

        }
    }

}
