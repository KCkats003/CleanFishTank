using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountKoi : MonoBehaviour
{
    //COUNT 
    GameObject[] fishNumbers;
    public TMPro.TextMeshProUGUI fishNum; //the physical counter on screen 
    // Start is called before the first frame update
    void Start()
    {

        //HEALTH 
        HealthBar.setmaxhealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        //COUNT 
        fishNumbers = GameObject.FindGameObjectsWithTag("Koi");
        Debug.Log("Hi");
        fishNum.text = fishNumbers.Length.ToString();
        //Debug.Log();

        //HEALTH 
        TakeDamage(1);

    }

    //MAKE THE HEALTH BAR DO SHIT 
    public HealthBar HealthBar;
    //public int maxHealth = 1000;
    public int maxHealth;
    public int currenthealth;

    //HEALTH 
    void TakeDamage(int Damage)
    {
        currenthealth = currenthealth - Damage;
        HealthBar.sethealth(currenthealth);
    }


}
