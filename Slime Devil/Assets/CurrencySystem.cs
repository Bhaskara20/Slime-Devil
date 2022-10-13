using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{
    [SerializeField]
    public int count;
    public Text coin;
    // Start is called before the first frame update
    void Start()
    {
        count = PlayerPrefs.GetInt("coins");
        //coin.text = count.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            count = 0;
            PlayerPrefs.SetInt("coins", count);
        }
        count = PlayerPrefs.GetInt("coins");
        coin.text = count.ToString("0");
      
    }

    public void buyCurrency()
    {
        count += 10;
        PlayerPrefs.SetInt("coins",count);
        
    }
}
