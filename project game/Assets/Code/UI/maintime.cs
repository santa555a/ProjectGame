using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maintime : MonoBehaviour
{
    float minute = 0;
    public float hour = 8;
    int daytime = 1;
    public static maintime instant;
    [SerializeField]
    Text showtime;
    [SerializeField]
    Text showday;

    
    void Start()
    {
        showtime.text = minute.ToString();
        instant = this;
    }

    
    void Update()
    {
        if (minute >= 9  )
        {
            hour += 1;
            minute = 0;
        }
        if (hour >= 18)
        {
            hour = 8;
            daytime += 1;
        }
        
        minute += Time.deltaTime;
        showtime.text ="TIME : "+ hour.ToString()+":"  + Mathf.Round(minute).ToString();
        showday.text = "DAY : " + daytime;
    }
}
