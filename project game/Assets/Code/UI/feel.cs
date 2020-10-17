using UnityEngine;
using UnityEngine.UI;

public class feel :Feeling 
{
    [SerializeField]
    Text statustext;
    

    private void Start()
    {
       
    }
    void Update()
    {
        
        if (maintime.instant.hour >= 12)
        {
            statustext.text = "HUNGRY";
        }
        else if (feelbar.value >= 50 )
        {
            statustext.text = "HAPPY";
        }
        else if (feelbar.value <= 50)
        {
            statustext.text = "NORMAL";
        }

    }
}
