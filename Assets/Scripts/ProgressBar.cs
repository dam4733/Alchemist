using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public float progress;
    
    // Start is called before the first frame update
    public void Start()
    {
        slider.value = ClassPlayer.ActionPoints;
        progress = ClassPlayer.ActionPoints;
        
    }
    public void Update()
    {
      if (ClassPlayer.ActionPoints != progress)
        {
            slider.value = ClassPlayer.ActionPoints;
            progress = ClassPlayer.ActionPoints;
        }
        
    }

    // Update is called once per frame
    public void UseEnergy()
    {
        ClassPlayer.ActionPoints -= 1;
    }

    public void IsThereAnyEnergy()
    {
        if (ClassPlayer.ActionPoints <= 0)
        {
            ClassPlayer.Action = false;
        }
    }
}
