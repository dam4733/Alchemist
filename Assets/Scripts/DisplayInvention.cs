using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayInvention : MonoBehaviour
{
    public TextMeshProUGUI textField;
    // Start is called before the first frame update
    public void Start()
    {
        textField.text = "Invention lvl: " + ClassPlayer.InventionLevel + "\n" + ClassPlayer.InventionExperience + "/"+ClassPlayer.InventionLevel*100;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
}
