using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GenerateRandom 
{
    // Start is called before the first frame update
    public static  int Rand(int choose)
    {

        var number = Random.Range(0, choose);
        return number;

    }
}
