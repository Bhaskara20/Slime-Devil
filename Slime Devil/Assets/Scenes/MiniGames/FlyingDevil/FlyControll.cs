using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlyControll : MonoBehaviour
{
    //[SerializeField]
    public float speed;
    //[SerializeField]
    public float jump;
    public int coin;
    public float additioned;
    public Text score;
    public Text HighScore;
    public int additionit;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOver.SetActive(false);
        HighScore.text = "High Score : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coin = PlayerPrefs.GetInt("coins");
        additioned += 1 * Time.deltaTime;
        score.text = "Score : " + additioned.ToString("0");
        Debug.Log(coin);

        additionit = (int)additioned;

        if (additioned > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", additionit);
            HighScore.text = "High Score : " + additionit.ToString("0");
        }

        //PlayerPrefs.SetInt("coins",coin + (int)additioned);
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.W))
        {
            /*if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
            }*/
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy" || other.tag == "Barrier")
        {
            PlayerPrefs.SetInt("coins", coin + (int)additioned);


            //gameObject.SetActive(false);
            //SceneManager.LoadScene("FlyingDevil");

            gameOver.SetActive(true);
            stopTime();

            //PlayerPrefs.SetInt("coins", coin);
            //Invoke("death", 3f);
            //anim
            //anim.Play("death");
            //respawn();
            //anim.Play("death");
        }

        /*if(other.tag == "coin")
        {
            additioned += 1;
        }*/

    }

    void stopTime()
    {
        Time.timeScale = 0;
    }

    void meninggoy()
    {
        stopTime();
    }

    public void restart()
    {
        SceneManager.LoadScene("FlyingDevil");
        
    }

    public void back()
    {
        SceneManager.LoadScene("Test1");
    }
}
