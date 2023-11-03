using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using TMPro;
using UnityEngine;

public class Decisions : MonoBehaviour
{
    public TextMeshProUGUI textField;
    // Start is called before the first frame update
    public int Rand(int choose)
    {

        var number = Random.Range(0, choose);
        return number;
        
    }
    public void DisplayDecision()
    {
        if (ClassPlayer.Action == true)
        {

            if (StateClass.Finances == 3 && StateClass.Stability == 3 && StateClass.Order == 3)
            {
                DecisionTextTabs tabs = new DecisionTextTabs();
                textField.text = tabs.EventDialog[ClassPlayer.NumberOfEvents];
            }
            else if (StateClass.Finances ==4)
            {
                DecisionTextTabs tabs = new DecisionTextTabs();
                textField.text = tabs.BadEventHighFinance[ClassPlayer.NumberOfEvents];
            }

        }
        
    }
    public void DisplayChoose1()
    {
        if (ClassPlayer.Action == true)
        {
            if (StateClass.Finances == 3 && StateClass.Stability == 3 && StateClass.Order == 3)
            {
                DecisionTextTabs tabs = new DecisionTextTabs();
                textField.text = tabs.Decision1Dialog[ClassPlayer.NumberOfEvents];
            }
            else if (StateClass.Finances == 4)
            {
                DecisionTextTabs tabs = new DecisionTextTabs();
                textField.text = tabs.BadDecision1HighFinance[ClassPlayer.NumberOfEvents];
            }
        }
    }
    public void DisplayChoose2()
    {
        if (ClassPlayer.Action == true)
        {
            if (StateClass.Finances == 3 && StateClass.Stability == 3 && StateClass.Order == 3)
            {
                DecisionTextTabs tabs = new DecisionTextTabs();
                textField.text = tabs.Decision2Dialog[ClassPlayer.NumberOfEvents];
            }
            else if (StateClass.Finances == 4)
            {
                DecisionTextTabs tabs = new DecisionTextTabs();
                textField.text = tabs.BadDecision2HighFinance[ClassPlayer.NumberOfEvents];
            }
        }
    }
    public void Generate()
    {
        if (ClassPlayer.Action == true)
        {
            if (ClassPlayer.NumberOfEvents == 0)
            {
                ClassPlayer.NumberOfEvents = Rand(10); /// tu cyfra tyle ile dostêpnych decyzji
            }

        }
        
    }
    public void Degenerate()
    {
        if (ClassPlayer.NumberOfEvents !=0)
        {
            ClassPlayer.NumberOfEvents = 0;
        }

    }
    public void EffectsFor1()
    {
        Debug.Log(ClassPlayer.NumberOfEvents);
        if (StateClass.Finances == 3 && StateClass.Stability == 3 && StateClass.Order == 3)
        {
            switch (ClassPlayer.NumberOfEvents)
            {
                case 0:
                    {
                        StateClass.Finances += 1;

                        break;
                    }
                case 1:
                    {
                        StateClass.Finances += 1;

                        break;
                    }
                case 2:
                    {
                        StateClass.Finances += 1;

                        break;
                    }
                case 3:
                    {
                        HerbClass.Herb4Quantity += 1;

                        break;
                    }
                case 4:
                    {
                        HerbClass.Herb5Quantity += 1;

                        break;
                    }
                case 5:
                    {
                        HerbClass.Herb6Quantity += 1;

                        break;
                    }
                case 6:
                    {
                        ClassPlayer.Gold += 7;

                        break;
                    }
                case 7:
                    {
                        ClassPlayer.Gold += 8;

                        break;
                    }
                case 8:
                    {
                        ClassPlayer.Gold += 9;

                        break;
                    }
                case 9:
                    {
                        ClassPlayer.Gold += 10;

                        break;
                    }


            }
        }
        else if (StateClass.Finances == 4)
        {
            switch (ClassPlayer.NumberOfEvents)
            {
                case 0:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 1:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 2:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 3:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 4:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 5:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 6:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 7:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 8:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }
                case 9:
                    {
                        ClassPlayer.Gold -= 1;

                        break;
                    }


            }
        }

            Degenerate();
    }
    public void EffectsFor2()
    {
        Debug.Log((ClassPlayer.NumberOfEvents));
        switch ((ClassPlayer.NumberOfEvents))
        {
            case 0:
                {
                    StateClass.Finances -= 1;

                    break;
                }
            case 1:
                {
                    StateClass.Finances -= 1;

                    break;
                }
            case 2:
                {
                    StateClass.Finances -= 1;

                    break;
                }
            case 3:
                {
                    ClassPlayer.Gold -= 4;

                    break;
                }
            case 4:
                {
                    ClassPlayer.Gold -= 5;

                    break;
                }
            case 5:
                {
                    ClassPlayer.Gold -= 6;

                    break;
                }
            case 6:
                {
                    ClassPlayer.Gold -= 7;

                    break;
                }
            case 7:
                {
                    ClassPlayer.Gold -= 8;

                    break;
                }
            case 8:
                {
                    ClassPlayer.Gold -= 9;

                    break;
                }
            case 9:
                {
                    ClassPlayer.Gold -= 10;

                    break;
                }

        }
        Degenerate();
    }

    /*public void Start()
    {
        DisplayDecision();
        
    }*/


}
