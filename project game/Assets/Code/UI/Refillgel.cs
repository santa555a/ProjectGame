using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refillgel : MonoBehaviour
{
    public int beem;
    
    
    
    public void gelrefillfuntion()
    {
        Gelfill.gelout.gelrefill = 100;
        money.pay.moneyhave -= 100;
        beem = Random.Range(0, 5);
        Debug.Log(beem);
    }
}
