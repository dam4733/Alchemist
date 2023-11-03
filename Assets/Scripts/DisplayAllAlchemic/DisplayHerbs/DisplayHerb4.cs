using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHerb4 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;

    private int amountOfHerbs4;

    // Start is called before the first frame update


    public void Start()
    {

        textField.text = HerbClass.Herb4Quantity.ToString();
        amountOfHerbs4 = HerbClass.Herb4Quantity;
        Debug.Log("Przypisuje");

    }

    public void Update()
    {
        if (HerbClass.Herb4Quantity != amountOfHerbs4)
        {
            textField.text = HerbClass.Herb4Quantity.ToString();
            amountOfHerbs4 = HerbClass.Herb4Quantity;
        }
    }
}
