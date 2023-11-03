using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayStonesQuantity : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textFieldforOne;
    public TextMeshProUGUI textFieldforTwo;
    public TextMeshProUGUI textFieldforThree;
    public TextMeshProUGUI textFieldforFour;

    public void Update()
    {
        textFieldforOne.text = StoneClass.Stone1Quantity.ToString();
        textFieldforTwo.text = StoneClass.Stone2Quantity.ToString();
        textFieldforThree.text = StoneClass.Stone3Quantity.ToString();
        textFieldforFour.text = StoneClass.Stone4Quantity.ToString();
    }

}
