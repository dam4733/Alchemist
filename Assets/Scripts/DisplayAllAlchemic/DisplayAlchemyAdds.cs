using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayAlchemyAdds : MonoBehaviour
{
    public TextMeshProUGUI textField;
    // Start is called before the first frame update
    public void DisplayPotionGenerate1Adds()
    {
        if (ClassPlayer.AlchemyLevel == 1) 
        {
            textField.text = "+2 experience";
        }
    }
    public void Update()
    {

        if (ClassPlayer.AlchemyLevel <= 2)
        {
            textField.text = "+2 experience";
        }
        else if (ClassPlayer.AlchemyLevel >=3 && ClassPlayer.AlchemyLevel<6) 
        {
            textField.text = "+1 experience";
        }
        else
        {
            textField.text = string.Empty;
        }
    }
}
