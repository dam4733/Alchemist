using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Reguirements : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public int Gem1 = 0;
    public int Gem2 = 0;
    public int Gem3 = 0;
    public int Gem4 = 0;
    public GameObject panel;
    public RawImage image;

    public RawImage Basicimage {  get; set; }

    public void SetGem1 (int gem1)
    {  if (gem1 == 0)
        {
            Gem1 = 1;
            Gem2 = 2;
            Gem3 = 3;
            Gem4 = 4;
            image.texture = Basicimage.texture;
            
            
            
            
           
            
           
        }
    else if (gem1 == 1) 
            {
                Gem1 = 10;
                Gem2 = 20;
                Gem3 = 30;
                Gem4 = 40;
            image.texture = Basicimage.texture;
        }
       
        panel.SetActive(true);
        
        text1.text = StoneClass.Stone1Quantity + "/" + Gem1.ToString();
        text2.text = StoneClass.Stone2Quantity + "/" + Gem2.ToString();
        text3.text = StoneClass.Stone3Quantity + "/" + Gem3.ToString();
        text4.text = StoneClass.Stone4Quantity + "/" + Gem4.ToString();
        InventionClass.isInvention1Active = true;
        Debug.Log(InventionClass.isInvention1Active);


    }
    
    
    public void Start()
    {
        panel.SetActive(false);
    }
    public void Update()
    {
        text1.text = StoneClass.Stone1Quantity + "/" + Gem1.ToString();
        text2.text = StoneClass.Stone2Quantity + "/" + Gem2.ToString();
        text3.text = StoneClass.Stone3Quantity + "/" + Gem3.ToString();
        text4.text = StoneClass.Stone4Quantity + "/" + Gem4.ToString();
    }
}



