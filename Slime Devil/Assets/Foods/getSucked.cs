using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getSucked : MonoBehaviour
{
    public GameObject devil;
    private float speed = 50f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        findPlayer();
    }

    void findPlayer()
    {
        devil = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (devil == null)
        {
            findPlayer();
        }
        else
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, devil.transform.position, speed * Time.deltaTime);
            rb.MovePosition(pos);
        }
    }
}
