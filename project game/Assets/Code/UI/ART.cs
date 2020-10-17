using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ART : MonoBehaviour
{
    float Artvalue = 0;
    [SerializeField]
    Text ArtText;
    [SerializeField]
    Slider Artlider;

    // Update is called once per frame
    void Update()
    {
        ArtText.text = "ART : " + Mathf.Round(Artvalue).ToString(); ;
        Artlider.value = Artvalue;
        
    }
    public void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Artitem")
        {
            Artvalue += Time.deltaTime / 10;
        }


    }
}
