using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatfood : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }
    public void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Staff")
        {
            Destroy(gameObject);
            Feeling.fill.gel += 10;
        }
    }
}