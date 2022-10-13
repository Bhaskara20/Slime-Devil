using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpKiri : MonoBehaviour
{
    private Rigidbody2D rb;

    private float jumpPower = 30f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        jumpLeft();
    }

    void jumpKanan()
    {
        rb.AddForce(Vector2.up * jumpPower);
        rb.AddForce(Vector2.right * 10);
    }

    void jumpLeft()
    {
        rb.AddForce(Vector2.up * jumpPower);
        rb.AddForce(Vector2.left * 10);
    }
}
