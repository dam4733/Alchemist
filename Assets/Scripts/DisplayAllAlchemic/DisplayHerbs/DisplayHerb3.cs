using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHerb3 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;

    private int amountOfHerbs3;

    // Start is called before the first frame update


    public void Start()
    {

        textField.text = HerbClass.Herb3Quantity.ToString();
        amountOfHerbs3 = HerbClass.Herb3Quantity;
        Debug.Log("Przypisuje");

    }

    public void Update()
    {
        if (HerbClass.Herb3Quantity != amountOfHerbs3)
        {
            textField.text = HerbClass.Herb3Quantity.ToString();
            amountOfHerbs3 = HerbClass.Herb3Quantity;
        }
    }
}
