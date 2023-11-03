using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPotion2 : MonoBehaviour
{
    public TextMeshProUGUI textField;
    private int amountOfPotions2;
    // Start is called before the first frame update
    public void Start()
    {

        textField.text = PotionClass.Potion2Quantity.ToString();
        amountOfPotions2 = PotionClass.Potion2Quantity;

    }

    // Update is called once per frame
    public void Update()
    {
        if (PotionClass.Potion2Quantity != amountOfPotions2)
        {
            textField.text = PotionClass.Potion2Quantity.ToString();
            amountOfPotions2 = PotionClass.Potion2Quantity;
        }
    }
}
