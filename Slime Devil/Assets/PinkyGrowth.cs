using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyGrowth : MonoBehaviour
{
    //public Transform spawner;
    public GameObject toddler;
    public GameObject teen;
    public GameObject adult;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "pinky (baby)" || gameObject.name == "pinky (baby)(Clone)")
        {
            StartCoroutine(baby2toddler());
        }else if (gameObject.name == "pinky (toddler)" || gameObject.name == "pinky (toddler)(Clone)")
        {
            StartCoroutine(toddler2teen());
        }else if (gameObject.name == "pinky (teen)" || gameObject.name == "pinky (teen)(Clone)")
        {
            StartCoroutine(teen2adult());
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator baby2toddler()
    {
        Debug.Log("Grow to toddler in 10 seconds");
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
        Instantiate(toddler, new Vector3(-2.73f, 1.12f, 0f), Quaternion.identity);
    }

    IEnumerator toddler2teen()
    {
        Debug.Log("Grow to teen in 10 seconds");
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
        Instantiate(teen, new Vector3(-2.73f, 1.12f, 0f), Quaternion.identity);
    }

    IEnumerator teen2adult()
    {
        Debug.Log("Grow to adult in 10 seconds");
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
        Instantiate(adult, new Vector3(-2.73f, 1.12f, 0f), Quaternion.identity);
    }
}
