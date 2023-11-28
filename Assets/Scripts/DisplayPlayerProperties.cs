using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public TextMeshProUGUI ActualEnergy;
    private int poprzednipoziom;
    // Start is called before the first frame update
    void Start()
    {
        textField.text = "Level "+ ClassPlayer.LevelOFPlayer;
        poprzednipoziom = ClassPlayer.LevelOFPlayer;
        ActualEnergy.text ="Energy "+ ClassPlayer.ActionPoints.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClassPlayer.LevelOFPlayer != poprzednipoziom) {
            textField.text = "Level " + ClassPlayer.LevelOFPlayer;
            poprzednipoziom = ClassPlayer.LevelOFPlayer;
           
        }
        ActualEnergy.text = "Energy " + ClassPlayer.ActionPoints.ToString();
    }
}
