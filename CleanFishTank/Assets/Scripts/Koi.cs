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

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
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
            // Whatever you want it to do.
            Destroy(gameObject);
        }
    }

}
