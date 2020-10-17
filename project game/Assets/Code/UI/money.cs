using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    public int moneyhave = 25000;
    [SerializeField]
    Text showmoney;
    public static money pay;
    void Start()
    {
        pay = this;
    }

    
    void Update()
    {
        showmoney.text =  "" + moneyhave;
    }
}
