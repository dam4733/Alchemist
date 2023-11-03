using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHerbs : MonoBehaviour
{
    public TextMeshProUGUI textField;

    
    
    // Start is called before the first frame update
    
    
    public void Start()
    {
        
            textField.text = HerbClass.Herb1Quantity.ToString();

    }
    
    public void Update()
    {
        
        if (HerbClass.Herb1Quantity.ToString() != textField.text)
        {
           
            textField.text = HerbClass.Herb1Quantity.ToString();
        }
    }
    

    // Update is called once per frame

}
