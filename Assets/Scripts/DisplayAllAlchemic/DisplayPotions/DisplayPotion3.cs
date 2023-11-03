using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPotion3 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;
    private int amountOfPotions3;
    // Start is called before the first frame update
    public void Start()
    {

        textField.text = PotionClass.Potion3Quantity.ToString();
        amountOfPotions3 = PotionClass.Potion3Quantity;

    }

    // Update is called once per frame
    public void Update()
    {
        if (PotionClass.Potion3Quantity != amountOfPotions3)
        {
            textField.text = PotionClass.Potion3Quantity.ToString();
            amountOfPotions3 = PotionClass.Potion3Quantity;
        }
    }
}
