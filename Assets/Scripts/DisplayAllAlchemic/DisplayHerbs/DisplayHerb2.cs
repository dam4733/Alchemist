using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHerb2 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;

    private int amountOfHerbs2;

    // Start is called before the first frame update


    public void Start()
    {

        textField.text = HerbClass.Herb2Quantity.ToString();
        amountOfHerbs2 = HerbClass.Herb2Quantity;
        Debug.Log("Przypisuje");

    }

    public void Update()
    {
        if (HerbClass.Herb2Quantity != amountOfHerbs2)
        {
            textField.text = HerbClass.Herb2Quantity.ToString();
            amountOfHerbs2 = HerbClass.Herb2Quantity;
        }
    }
}
