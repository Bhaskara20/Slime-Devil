using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    [SerializeField] GameObject stawberry;
    private int coin;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("i");
    }

    // Update is called once per frame
    void Update()
    {
        coin = PlayerPrefs.GetInt("coins");
        //Debug.Log(coin);
        if (coin > 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Vector3 spawnPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject s = Instantiate(stawberry, (Vector2)spawnPos, Quaternion.identity);
                coin -= 10;
                PlayerPrefs.SetInt("coins", coin);
            }
        }
        else
        {
            Debug.Log("Kurang Duit");
        }
        
    }
}
