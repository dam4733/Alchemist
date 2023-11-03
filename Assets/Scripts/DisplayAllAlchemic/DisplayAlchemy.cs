using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayAlchemy : MonoBehaviour
{
    public TextMeshProUGUI textField;
    private int AlchemyExpereince;
    // Start is called before the first frame update
    public void Start()
    {
        textField.text = "Alchemy lvl: " + ClassPlayer.AlchemyLevel + "\n" + ClassPlayer.AlchemyExperience +"/"+ ClassPlayer.AlchemyLevel*100;
        AlchemyExpereince = ClassPlayer.AlchemyExperience;
    }

    // Update is called once per frame
    public void Update()
    {
        if (ClassPlayer.AlchemyExperience != AlchemyExpereince)
        {
            textField.text = "Alchemy lvl: " + ClassPlayer.AlchemyLevel + "\n" + ClassPlayer.AlchemyExperience + "/" + ClassPlayer.AlchemyLevel * 100;
            AlchemyExpereince = ClassPlayer.AlchemyExperience;
        }
        if (ClassPlayer.AlchemyExperience >= (ClassPlayer.AlchemyLevel)*100)
        {
            ClassPlayer.AlchemyLevel += 1;
            ClassPlayer.AlchemyExperience = 0;
        }
    }
}
