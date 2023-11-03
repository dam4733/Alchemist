using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LookingForStone : MonoBehaviour
{
    // Start is called before the first frame update
    public void Generate()
    {
        int resoult = GenerateRandom.Rand(10);
        if (resoult == 1)
            Debug.Log("Znalaz³eœ 1");
        else if (resoult == 2)
            Debug.Log("Znalaz³eœ 2");
        else if (resoult == 3)
            Debug.Log("Znalaz³eœ 3");
        else if (resoult == 4)
            Debug.Log("Znalaz³eœ 4");
        else
            Debug.Log("Niepowodzenie");

    }
    

}
