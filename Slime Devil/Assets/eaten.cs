using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eaten : MonoBehaviour
{
    //public HungerManager lapar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(lapar.currentHunger);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //lapar.currentHunger += 100;
            
            //lapar.current
            //lapar.currentHunger;
            //Debug.Log("i just touched my food");
            //food = null;
            Destroy(gameObject);
        }

    }
}
