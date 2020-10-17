using UnityEngine;
using UnityEngine.UI;

public class Feeling : MonoBehaviour
{
    
    public float gel = 30;
    
    [SerializeField]
    public Slider feelbar;
    [SerializeField]
    Text feelingtext;
    public static Feeling fill;
    void Start()
    {
        fill = this ;
    }
        void Update()
    {
       
        
        

    }
        public void OnCollisionStay(Collision collisionInfo)
    {   if (Gelfill.gelout.gelrefill >= 1)
        {
            if (collisionInfo.collider.tag == "Gel" && gel <= 100)
            {
                gel++;
                feelingtext.text = "Washing";
            }
        }
        if (collisionInfo.collider.tag == "Computer")
        {
            feelingtext.text = "Working";
            gel-=Time.deltaTime;
        }
        if (collisionInfo.collider.tag == "Artitem")
        {
            feelingtext.text = "Working";
            gel -= Time.deltaTime;
        }
        feelbar.value = gel;
        if (feelbar.value >= 51 && collisionInfo.collider.tag != "Gel" && collisionInfo.collider.tag != "Computer" && collisionInfo.collider.tag != "Artitem")
        {
            feelingtext.text = "";
        }
        else if (feelbar.value <= 50 && collisionInfo.collider.tag != "Gel" && collisionInfo.collider.tag != "Computer" && collisionInfo.collider.tag != "Artitem")
        {
            feelingtext.text = "Dirty";
        }
        if(gel<=0)
            gel=0;

        
    }
}
