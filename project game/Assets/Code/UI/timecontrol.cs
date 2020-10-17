using UnityEngine;

public class timecontrol : MonoBehaviour
{
    
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void play()
    {
        Time.timeScale = 1;
    }
    public void fast()
    {
        Time.timeScale = 3;
    }
    public void faster()
    {
        Time.timeScale = 20;
    }
}
