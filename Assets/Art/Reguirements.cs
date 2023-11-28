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
    public TextMeshProUGUI Gold;
    public TextMeshProUGUI TextAboutInvention;
    public TextMeshProUGUI CraftedOrNot;
    public int Gem1 = 0;
    public int Gem2 = 0;
    public int Gem3 = 0;
    public int Gem4 = 0;
    public int GoldPrice = 0;
    public string DescriptionInvention1 { get;set; }
    public string DescriptionInvention2 { get;set; }
    public string DescriptionInvention3 { get;set; }
    public string DescriptionInvention4 { get;set; }
    public string DescriptionInvention5 { get;set; }
    public string DescriptionInvention6 { get;set; }
    public string DescriptionInvention7 { get;set; }
    public string DescriptionInvention8 { get;set; }
    public string DescriptionInvention9 { get;set; }
    public string DescriptionInvention10 { get;set; }
    public string DescriptionInvention11 { get;set; }
    public string DescriptionInvention12 { get;set; }
    public string DescriptionInvention13 { get;set; }
    public string DescriptionInvention14 { get;set; }
    public string DescriptionInvention15 { get;set; }
    public string DescriptionInvention16 { get;set; }
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
            GoldPrice = 50;
            DescriptionInvention1 = "This is cristal ball";
            TextAboutInvention.text = DescriptionInvention1;
            
            Gold.text = GoldPrice.ToString()+"/"+ ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention1Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention1Active = true;

        }
    else if (gem1 == 1) 
            {
                Gem1 = 10;
                Gem2 = 20;
                Gem3 = 30;
                Gem4 = 40;
            GoldPrice = 100;
            DescriptionInvention2 = "This is some item";
            TextAboutInvention.text = DescriptionInvention2;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention2Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention2Active = true;
        }
        else if (gem1 == 2)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 200;
            DescriptionInvention3 = "This is some item3";
            TextAboutInvention.text = DescriptionInvention3;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention3Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention3Active = true;
        }
        else if (gem1 == 3)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 300;
            DescriptionInvention4 = "This is some item4";
            TextAboutInvention.text = DescriptionInvention4;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention4Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention4Active = true;
        }
        else if (gem1 == 4)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 400;
            DescriptionInvention5 = "This is some item5";
            TextAboutInvention.text = DescriptionInvention5;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention5Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention5Active = true;
        }
        else if (gem1 == 5)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 500;
            DescriptionInvention6 = "This is some item6";
            TextAboutInvention.text = DescriptionInvention6;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention6Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention6Active = true;
        }
        else if (gem1 == 6)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 600;
            DescriptionInvention7 = "This is some item7";
            TextAboutInvention.text = DescriptionInvention7;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention7Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention7Active = true;
        }
        else if (gem1 == 7)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 700;
            DescriptionInvention8 = "This is some item8";
            TextAboutInvention.text = DescriptionInvention8;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention8Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention8Active = true;
        }
        else if (gem1 == 8)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 800;
            DescriptionInvention9 = "This is some item9";
            TextAboutInvention.text = DescriptionInvention9;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention9Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention9Active = true;
        }
        else if (gem1 == 9)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 900;
            DescriptionInvention10 = "This is some item10";
            TextAboutInvention.text = DescriptionInvention10;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention10Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention10Active = true;
        }
        else if (gem1 == 10)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 1000;
            DescriptionInvention11 = "This is some item11";
            TextAboutInvention.text = DescriptionInvention11;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention11Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention11Active = true;
        }
        else if (gem1 == 11)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 1100;
            DescriptionInvention12 = "This is some item12";
            TextAboutInvention.text = DescriptionInvention12;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention12Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention12Active = true;
        }
        else if (gem1 == 12)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 1200;
            DescriptionInvention13 = "This is some item13";
            TextAboutInvention.text = DescriptionInvention13;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention13Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention13Active = true;
        }
        else if (gem1 == 13)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 1300;
            DescriptionInvention14 = "This is some item14";
            TextAboutInvention.text = DescriptionInvention14;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention14Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention14Active = true;
        }
        else if (gem1 == 14)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 1400;
            DescriptionInvention15 = "This is some item15";
            TextAboutInvention.text = DescriptionInvention15;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention15Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention15Active = true;
        }
        else if (gem1 == 15)
        {
            Gem1 = 10;
            Gem2 = 20;
            Gem3 = 30;
            Gem4 = 40;
            GoldPrice = 1500;
            DescriptionInvention16 = "This is some item16";
            TextAboutInvention.text = DescriptionInvention16;
            Gold.text = GoldPrice.ToString() + "/" + ClassPlayer.Gold.ToString();
            image.texture = Basicimage.texture;
            if (InventionClass.isInvention16Exist)
            {
                CraftedOrNot.text = "Use";
            }
            else
            {
                CraftedOrNot.text = "Not crafted";
            }
            InventionClass.isInvention16Active = true;
        }

        panel.SetActive(true);
        
        text1.text = StoneClass.Stone1Quantity + "/" + Gem1.ToString();
        text2.text = StoneClass.Stone2Quantity + "/" + Gem2.ToString();
        text3.text = StoneClass.Stone3Quantity + "/" + Gem3.ToString();
        text4.text = StoneClass.Stone4Quantity + "/" + Gem4.ToString();
        
        


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
    public void HidePanel()
    {
        panel.SetActive(false);
    }
}



