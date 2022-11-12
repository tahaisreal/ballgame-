using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public int JumpForce;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * JumpForce);
    }
}
