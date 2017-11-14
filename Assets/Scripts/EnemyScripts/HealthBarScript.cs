using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {
    public int lives;
    public int maxHealth = 100;
    public int curHealth = 50;
    bool bossActive = true;
    float barValue;
    Slider slider;

    void Start()
    {
        slider = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<Slider>();
        StartCoroutine(SetHealthBar());
    }
    

    IEnumerator SetHealthBar()
    {
        while (bossActive)
        {
            barValue = ((float)curHealth) / ((float)maxHealth);
            slider.value = barValue;
            yield return new WaitForEndOfFrame();
        }
    }

}
