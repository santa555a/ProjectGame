using UnityEngine;

public class Foodspawn : MonoBehaviour
{
    public GameObject Foodpanda;
    public Vector3 pointspawn;

    public void spawnfood() 
    {
        Instantiate(Foodpanda, pointspawn,Quaternion.identity);
        money.pay.moneyhave -= 100;
    }
}
