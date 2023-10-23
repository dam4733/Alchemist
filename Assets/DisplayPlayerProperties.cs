using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textField;
    private int poprzednipoziom;
    // Start is called before the first frame update
    void Start()
    {
        textField.text = "Level "+ ClassPlayer.LevelOFPlayer;
        poprzednipoziom = ClassPlayer.LevelOFPlayer;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ClassPlayer.LevelOFPlayer != poprzednipoziom) {
            textField.text = "Level " + ClassPlayer.LevelOFPlayer;
            poprzednipoziom = ClassPlayer.LevelOFPlayer;
        }
    }
}
