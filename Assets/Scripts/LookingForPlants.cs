using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingForPlants : MonoBehaviour
{
    // Start is called before the first frame update
    public int Rand(int choose)
    {

        var number = Random.Range(0, choose);
        return number;

    }
    public void LookForPlatns()
    {
        int Resoult = Rand(2);
        if (Resoult == 1) 
        {
            HerbClass.Herb1Quantity += 1;
            Debug.Log("Found PLANT");
        }
        else 
        {
            Debug.Log("Missed");
        }
        Debug.Log(Resoult.ToString());
    }
}
