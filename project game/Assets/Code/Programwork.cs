using UnityEngine.UI;
using UnityEngine;

public class Programwork : MonoBehaviour
{
    
    float percent =0;
    [SerializeField]
    Text programText;
    [SerializeField]
    Slider programslider;


    void Update()
    {
        programText.text = "PROGRAM : " + Mathf.Round(percent).ToString();
        programslider.value = percent;
    }
    public void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Computer")
        {
            percent += Time.deltaTime/10;
        }
        

    }
}
