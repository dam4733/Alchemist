using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class UsingEnergy : MonoBehaviour
{
    // Start is called before the first frame update
    public void UseEnergy()
    {
        ClassPlayer.ActionPoints -= 1;
        if (ClassPlayer.ActionPoints < 10)
        {
            ClassPlayer.CountingAction = true;
            if (ClassPlayer.CountingInProgressFlag == false) 
            {
                ClassPlayer.CountingInProgressFlag = true;
            }
        }
    }

    public void IsThereAnyEnergy()
    {
        if (ClassPlayer.ActionPoints <= 0)
        {
            ClassPlayer.Action = false;
        }
        else if (ClassPlayer.ActionPoints >=1 ) 
        {
            ClassPlayer.Action = true;
        }

    }
    public void Update()
    {
        //Debug.Log(ClassPlayer.CountingAction);

        // ustaw max punkty akcji
        if (ClassPlayer.CountingAction ==  true) 
        {
            if (ClassPlayer.CountingInProgressFlag == true)
            {

                Clock.CatchTime = DateTime.Now;
                Clock.EndTime = Clock.CatchTime.AddMilliseconds(10000);


                ClassPlayer.CountingAction = false;
                //Debug.Log(Clock.EndTime.ToString());
                ClassPlayer.CountingInProgressFlag = null;
                
            }
        }
        //Debug.Log(Clock.EndTime.ToString());
        Clock.ActualTime = DateTime.Now;
        if (Clock.EndTime <= Clock.ActualTime)
        {
            //Debug.Log("Przekroczono");
            SetFullEnergy();
            ClassPlayer.CountingInProgressFlag = false;
        }
        




    }
   
    public void SetFullEnergy()
    {
        ClassPlayer.ActionPoints = 10;
    }


}
