using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGold : MonoBehaviour
{
    public TextMeshProUGUI textField;
    private int amountofGold;
    // Start is called before the first frame update
    public void Start()
    {
        textField.text = "Gold: " + ClassPlayer.Gold;
        amountofGold = ClassPlayer.Gold;
        Debug.Log(amountofGold);
    }

    // Update is called once per frame
    public void Update()
    {
        if (ClassPlayer.Gold != amountofGold)
        {
            textField.text = "Gold: " + ClassPlayer.Gold;
            amountofGold = ClassPlayer.Gold;
        }
    }
}
