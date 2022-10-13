using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatResponse : MonoBehaviour
{
    HungerManager lapar;
    GameObject manajerLaper;
    // Start is called before the first frame update
    void Start()
    {
        manajerLaper = GameObject.FindWithTag("HungerMan");
        lapar = manajerLaper.GetComponent<HungerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "food")
        {
            //lapar.currentHunger += 100;
            lapar.currentHunger += 100;
            //lapar.c
            //lapar.current
            //lapar.currentHunger;
            //Debug.Log("i just touched my food");
            //food = null;
            //Debug.Log("nyam nyam");
        }

        if (collision.gameObject.tag == "Beverage")
        {
            //lapar.currentThirst
            lapar.currentThirst += 100;

        }

        if (collision.gameObject.tag == "Meds")
        {
            //lapar.currentThirst
            lapar.currentHealth = lapar.startHealth;

        }

        if (collision.gameObject.tag == "toy")
        {
            lapar.currentHappiness += 100;
        }

    }
}
