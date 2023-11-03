using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public void Decyzja1 ()
    {
        ClassPlayer.Gold += 50;
        Debug.Log(ClassPlayer.Gold);
    }
    public void Decyzja2 ()
    {
        if ((ClassPlayer.Gold -= 50) >= 0)
        {

        }
        else
        {
            ClassPlayer.Gold += 50;
            Debug.Log(ClassPlayer.Gold);
        }
    }
}
