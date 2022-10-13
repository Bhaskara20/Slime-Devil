using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    
    public GameObject toy;
    private float playSpeed = 30f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        findToy();
    }

    void findToy()
    {
        toy = GameObject.FindWithTag("toy");
    }
    

    // Update is called once per frame
    void Update()
    {

        if (toy == null)
        {
            findToy();
        }
        else
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, toy.transform.position, playSpeed * Time.deltaTime);
            rb.MovePosition(pos);
        }
    }

    
}
