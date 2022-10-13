using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpControll : MonoBehaviour
{
    public GameObject devil;
    private int[] values;
    private int randomValue;
    // Start is called before the first frame update
    void Start()
    {
        values = new int[2];
        values[0] = 0;
        values[1] = 1;
        randomValue = Random.Range(0, values.Length);
        StartCoroutine(loncatDelay());
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    IEnumerator loncatDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            if (randomValue == 1)
            {
                devil.GetComponent<RandomJump>().enabled = true;
                yield return new WaitForSeconds(0.5f);
                devil.GetComponent<RandomJump>().enabled = false;
            }else if(randomValue == 0)
            {
                devil.GetComponent<jumpKiri>().enabled = true;
                yield return new WaitForSeconds(0.5f);
                devil.GetComponent<jumpKiri>().enabled = false;
            }
            randomValue = Random.Range(0, values.Length);

        }
        
        

    }
}
