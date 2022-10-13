using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerManager : MonoBehaviour
{
    public float currentHunger = 0f;
    public float startHunger = 18000f;
    

    public float currentThirst = 0f;
    public float startThirst = 18000f;

    public float currentHealth = 0f;
    public float startHealth = 18000f;

    public float currentHappiness = 0f;
    public float startHappiness = 18000f;
    
    public GameObject devil;

    public GameObject foodSpawner; //strawberyy
    public GameObject puddingSpawner;
    public GameObject cakeSpawner;
    public GameObject strawberryButton;
    public GameObject cakeButton;
    public GameObject puddingButton;

    public GameObject beverageSpawner; //smoothies
    public GameObject milkSpawner;
    public GameObject chocolateSpawner;
    public GameObject smoothiesButton;
    public GameObject milkButton;
    public GameObject chocolateButton;

    public GameObject medicineSpawner;
    public GameObject toy;

    public GameObject foodButton;
    public GameObject drinkButton;
    public GameObject healButton;
    public GameObject toyButton;

    public GameObject backButton;

    private bool isEat;
    private bool isDrink;
    private bool isHeal;
    private bool isPlay;

    private float hungerPercentage;
    private float thirstPercentage;
    private float healthPercentage;
    private float happyPercentage;

    [SerializeField] Text hungerText;
    [SerializeField] Text thirstText;
    [SerializeField] Text healthText;
    [SerializeField] Text happyText;
    // Start is called before the first frame update
    void Start()
    {
        //devil = GameObject.FindWithTag("core");
        currentHunger = startHunger;
        currentThirst = startThirst;
        currentHealth = startHealth;
        currentHappiness = startHappiness;

        Time.timeScale = 1;



    }

    // Update is called once per frame
    void Update()
    {
        hungerDecrease();
        thirstDecrease();
        healthDecrease();
        happinesDecrease();
    }

    public void eatTime()
    {
        //devil.GetComponent<RandomJump>().enabled = false;
        //devil.GetComponent<jumpControll>().enabled = false;
        //devil.GetComponent<Decide2Eat>().enabled = true;
        medicineSpawner.SetActive(false);
        beverageSpawner.SetActive(false);
        toy.SetActive(false);
        //foodSpawner.SetActive(true);
        //puddingSpawner.SetActive(true);
        //cakeSpawner.SetActive(true);

        foodButton.SetActive(false);
        drinkButton.SetActive(false);
        healButton.SetActive(false);
        toyButton.SetActive(false);
        backButton.SetActive(true);

        strawberryButton.SetActive(true);
        cakeButton.SetActive(true);
        puddingButton.SetActive(true);



        isEat = true;
        isDrink = false;
        isHeal = false;
        isPlay = false;
        
    }

    public void strawBuy()
    {
        cakeSpawner.SetActive(false);
        puddingSpawner.SetActive(false);
        foodSpawner.SetActive(true);
    }

    public void cakeBuy()
    {
        cakeSpawner.SetActive(true);
        puddingSpawner.SetActive(false);
        foodSpawner.SetActive(false);
    }

    public void puddingBuy()
    {
        cakeSpawner.SetActive(false);
        puddingSpawner.SetActive(true);
        foodSpawner.SetActive(false);
    }


    public void backResponse()
    {
        if (isEat == true)
        {
            backEat();
        }

        if (isDrink == true)
        {
            backDrink();
        }

        if(isHeal == true)
        {
            backHeal();
        }

        if (isPlay == true)
        {
            backPlay();
        }
        foodButton.SetActive(true);
        drinkButton.SetActive(true);
        healButton.SetActive(true);
        toyButton.SetActive(true);
    }
    public void backEat()
    {
        //foodButton.SetActive(true);
        cakeSpawner.SetActive(false);
        puddingSpawner.SetActive(false);
        foodSpawner.SetActive(false);
        backButton.SetActive(false);
        strawberryButton.SetActive(false);
        cakeButton.SetActive(false);
        puddingButton.SetActive(false);

    }

    public void backDrink()
    {
        //foodButton.SetActive(true);
        beverageSpawner.SetActive(false);
        backButton.SetActive(false);
        milkSpawner.SetActive(false);
        beverageSpawner.SetActive(false);
        chocolateSpawner.SetActive(false);
        smoothiesButton.SetActive(false);
        milkButton.SetActive(false);
        chocolateButton.SetActive(false);
        
    }

    public void backHeal ()
    {
        //foodButton.SetActive(true);
        medicineSpawner.SetActive(false);
        backButton.SetActive(false);
    }

    public void backPlay()
    {
        toy.SetActive(false);
        backButton.SetActive(false);
    }


    public void drinkTime()
    {
        medicineSpawner.SetActive(false);
        foodSpawner.SetActive(false);
        toy.SetActive(false);
        //beverageSpawner.SetActive(true);

        drinkButton.SetActive(false);
        backButton.SetActive(true);
        foodButton.SetActive(false);
        healButton.SetActive(false);
        toyButton.SetActive(false);

        smoothiesButton.SetActive(true);
        chocolateButton.SetActive(true);
        milkButton.SetActive(true);

        isEat = false;
        isDrink = true;
        isHeal = false;
        isPlay = false;
    }

    public void smoothieBuy()
    {
        chocolateSpawner.SetActive(false);
        milkSpawner.SetActive(false);
        beverageSpawner.SetActive(true);
    }

    public void milkBuy()
    {
        chocolateSpawner.SetActive(false);
        milkSpawner.SetActive(true);
        beverageSpawner.SetActive(false);
    }

    public void chocolateBuy()
    {
        chocolateSpawner.SetActive(true);
        milkSpawner.SetActive(false);
        beverageSpawner.SetActive(false);
    }
    
    public void healTime()
    {
        foodSpawner.SetActive(false);
        beverageSpawner.SetActive(false);
        toy.SetActive(false);
        medicineSpawner.SetActive(true);


        healButton.SetActive(false);
        backButton.SetActive(true);
        foodButton.SetActive(false);
        drinkButton.SetActive(false);
        toyButton.SetActive(false);


        isEat = false;
        isDrink = false;
        isHeal = true;
        isPlay = false;


    }

    public void playTime()
    {
        foodSpawner.SetActive(false);
        beverageSpawner.SetActive(false);
        toy.SetActive(true);
        medicineSpawner.SetActive(false);


        healButton.SetActive(false);
        backButton.SetActive(true);
        foodButton.SetActive(false);
        drinkButton.SetActive(false);
        toyButton.SetActive(false);


        isEat = false;
        isDrink = false;
        isHeal = false;
        isPlay = true;
    }

    void hungerDecrease()
    {
        currentHunger -= 1 * Time.deltaTime;
        //hungerText.text = "= " + currentHunger.ToString("0");
        
        if (currentHunger <= 0f)
        {
            currentHunger = 0f;
        }

        if (currentHunger >= startHunger)
        {
            currentHunger = startHunger;
        }

        hungerPercentage = (currentHunger / startHunger) * 100;
        hungerText.text = "% " + hungerPercentage.ToString("0");

    }


    void thirstDecrease()
    {
        currentThirst -= 1 * Time.deltaTime;
        //thirstText.text = "= " + currentThirst.ToString("0");
        if (currentThirst <= 0f)
        {
            currentThirst = 0f;
        }

        if (currentThirst >= startThirst)
        {
            currentThirst = startThirst;
        }

        thirstPercentage = (currentThirst / startThirst) * 100;
        thirstText.text = "% " + thirstPercentage.ToString("0");


    }

    void healthDecrease()
    {
        currentHealth -= 1 * Time.deltaTime;
        //healthText.text = "= " + currentHealth.ToString("0");
        if (currentHealth <= 0f)
        {
            currentHealth = 0f;
        }

        if (currentHealth >= startHealth)
        {
            currentHealth = startHealth;
        }

        healthPercentage = (currentHealth / startHealth) * 100;
        healthText.text = "% " + healthPercentage.ToString("0");
    }

    void happinesDecrease()
    {
        currentHappiness -= 1 * Time.deltaTime;
        //healthText.text = "= " + currentHealth.ToString("0");
        if (currentHappiness <= 0f)
        {
            currentHappiness = 0f;
        }

        if (currentHappiness >= startHappiness)
        {
            currentHappiness = startHappiness;
        }

        happyPercentage = (currentHappiness / startHappiness) * 100;
        happyText.text = "% " + happyPercentage.ToString("0");
    }
}
