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


    // Update is called once per frame
  //  void Update()
   // {
        
  //  }
}
