using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthBar : MonoBehaviour
{
    public int maxhealth; 

    public Slider slider;
    // Start is called before the first frame update
    // void Start()
    // {

    //  }

    public void setmaxhealth(int maxhealth)
    {

        slider.maxValue = maxhealth;
        slider.value = maxhealth;
    }

    public void sethealth(int health) {

        slider.value = health; 
    }

    //NEW 
    public int currenthealth;
    public HealthBar HealthBar1;

    void TakeDamage(int Damage)
    {
        currenthealth = currenthealth - Damage;
        HealthBar1.sethealth(currenthealth);
    }



    // Update is called once per frame
     void Update()
     {
        TakeDamage(1);
        if (currenthealth <= 0) {
            Debug.Log("Health is zero");

        }

    }
}
