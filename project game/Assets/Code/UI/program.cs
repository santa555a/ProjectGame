using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class program : MonoBehaviour
{
     int programvalue = 0;
    [SerializeField]
    Text programText;
    [SerializeField]
    Slider programslider;

    // Update is called once per frame
    void Update()
    {
        programText.text = "PROGRAM : " + programvalue;
        programslider.value = programvalue;
        if (Input.GetKeyDown(KeyCode.Z)&&programvalue<=99)
        {
            programvalue++;
        }
    }
}
