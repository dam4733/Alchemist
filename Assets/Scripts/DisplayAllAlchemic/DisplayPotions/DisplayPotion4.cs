using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPotion4 : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textField;
    private int amountOfPotions4;
    // Start is called before the first frame update
    public void Start()
    {

        textField.text = PotionClass.Potion4Quantity.ToString();
        amountOfPotions4 = PotionClass.Potion4Quantity;

    }

    // Update is called once per frame
    public void Update()
    {
        if (PotionClass.Potion4Quantity != amountOfPotions4)
        {
            textField.text = PotionClass.Potion4Quantity.ToString();
            amountOfPotions4 = PotionClass.Potion4Quantity;
        }
    }
}
