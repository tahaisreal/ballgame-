using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D rb2d;
    public float speed = 5f;
    [SerializeField]
    private float flapForce = 20f;
    bool isDead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Elements"){
            Debug.Log("activé");
               
                }
    }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead) 
        {
            rb2d.velocity = new Vector2 (1,0) * speed * Time.deltaTime;
            rb2d.AddForce(new Vector2 (0,1) * flapForce);
        }
    }
}
