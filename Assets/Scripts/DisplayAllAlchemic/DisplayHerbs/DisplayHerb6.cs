using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHerb6 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;

    private int amountOfHerbs6;

    // Start is called before the first frame update


    public void Start()
    {

        textField.text = HerbClass.Herb6Quantity.ToString();
        amountOfHerbs6 = HerbClass.Herb6Quantity;
        Debug.Log("Przypisuje");

    }

    public void Update()
    {
        if (HerbClass.Herb6Quantity != amountOfHerbs6)
        {
            textField.text = HerbClass.Herb6Quantity.ToString();
            amountOfHerbs6 = HerbClass.Herb6Quantity;
        }
    }
}
