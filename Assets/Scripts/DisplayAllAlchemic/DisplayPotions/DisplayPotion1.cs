using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayPotions : MonoBehaviour
{
    public TextMeshProUGUI textField;
    private int amountOfPotions1;
    // Start is called before the first frame update
    public void Start()
    {
       
        textField.text = PotionClass.Potion1Quantity.ToString();
        amountOfPotions1 = PotionClass.Potion1Quantity;
       
    }

    // Update is called once per frame
    public void Update()
    {
        if (PotionClass.Potion1Quantity != amountOfPotions1)
        {
            textField.text = PotionClass.Potion1Quantity.ToString();
            amountOfPotions1 = PotionClass.Potion1Quantity;
        }
    }
}
