using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gelfill : MonoBehaviour
{
    public int gelrefill = 100;
    [SerializeField]
    Text showempty;
    public static Gelfill gelout;
    void Start()
    {
        gelout = this;
    }


    void Update()
    {

        if (gelrefill == 0)
        { showempty.text = "Empty"; }
        else if (gelrefill >= 1)
        {
            showempty.text = "" + gelrefill;
        }
    }
    public void OnCollisionStay(Collision collisionusegel)
    {
        if (gelrefill >= 1)
        {
            if (collisionusegel.collider.tag == "Staff" && Feeling.fill.gel <= 99)
            {
                gelrefill--;
            }
        }
    }
}

