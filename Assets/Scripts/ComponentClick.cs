using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComponentClicked : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tutaj");
       
    }
    public void Sprawdzenie()
    {
        Debug.Log("Witaj");
    }

    // Update is called once per frame
    void Update()
    {
        if (ClassPlayer.Gold < 0)
        {
            ClassPlayer.Gold = 0;
        }
    }
}
