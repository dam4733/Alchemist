using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenageOfStateDisplays : MonoBehaviour
{
    public SpriteRenderer Finance1;
    public SpriteRenderer Finance2;
    public SpriteRenderer Finance3;
    public SpriteRenderer Finance4;
    public SpriteRenderer Finance5;
    public SpriteRenderer Stability1;
    public SpriteRenderer Stability2;
    public SpriteRenderer Stability3;
    public SpriteRenderer Stability4;
    public SpriteRenderer Stability5;
    public SpriteRenderer Order1;
    public SpriteRenderer Order2;
    public SpriteRenderer Order3;
    public SpriteRenderer Order4;
    public SpriteRenderer Order5;
    public Color GreenColor;
    // Start is called before the first frame update
    void Start()
    {
        
       SetColours();
      
    }

    // Update is called once per frame
    void Update()
    {
        SetColours();
    }

    public void SetColours()
    {
        switch (StateClass.Finances)
        {

            case 1:
                Finance1.color = GreenColor;
                break;
            case 2:
                Finance2.color = GreenColor;
                break;
            case 3:
                Finance3.color = GreenColor;
                break;
            case 4:
                Finance4.color = GreenColor;
                break;
            case 5:
                Finance5.color = GreenColor;
                break;
        }
        switch (StateClass.Stability) 
        {
            case 1:
                Stability1.color = GreenColor;
                break;
                case 2:
                Stability2.color = GreenColor;
                break;
                case 3:
                Stability3.color = GreenColor;
                break;
                case 4:
                Stability4.color = GreenColor;
                break;
                case 5:
                Stability5.color = GreenColor;
                break;
        }
        switch (StateClass.Order) 
        {
            case 1:
                Order1.color = GreenColor;
                break;
                case 2:
                Order2.color = GreenColor;
                break;
                case 3:
                Order3.color = GreenColor;
                break;
                case 4:
                Order4.color = GreenColor;
                break;
                case 5:
                Order5.color = GreenColor;
                break;
        }

    }
}
