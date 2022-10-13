using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostSpawn : MonoBehaviour
{
    public float minY = -4.65f, maxY = 4.65f;

    
    public GameObject GHOST;

    public float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", timer);
    }

    // Update is called once per frame
    void Spawn()
    {
        float posY = Random.Range(minY, maxY);
        Vector3 temp = transform.position;
        temp.y = posY;

        Instantiate(GHOST, temp, Quaternion.Euler(0f, 0f, 0f));

        Invoke("Spawn", timer);
    }
}
