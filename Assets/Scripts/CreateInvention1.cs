using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CreateInvention1 : MonoBehaviour
{
    public Button button;
    public RawImage image1;
    public RawImage image2;
    public RawImage image3;
    public RawImage image4;
    public RawImage image5;
    public RawImage image6;
    public RawImage image7;
    public RawImage image8;
    public RawImage image9;
    public RawImage image10;
    public RawImage image11;
    public RawImage image12;
    public RawImage image13;
    public RawImage image14;
    public RawImage image15;
    public RawImage image16;

    public TextMeshProUGUI CraftedOrNot;
    // Start is called before the first frame update
    public void Create()
    {
        Debug.Log(InventionClass.isInvention1Active);
        if (InventionClass.isInvention1Active == true)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image1.color = Color.green;
            Debug.Log("Zmieniono");
            InventionClass.isInvention1Active = false;
            InventionClass.isInvention1Exist = true;
            CraftedOrNot.text = "Use";

        }
        else if (InventionClass.isInvention2Active == true && InventionClass.isInvention1Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image2.color = Color.green;
            Debug.Log("Zmieniono");
            InventionClass.isInvention2Active = false;
            InventionClass.isInvention2Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention3Active == true && InventionClass.isInvention2Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image3.color = Color.green;
            
            InventionClass.isInvention3Active = false;
            InventionClass.isInvention3Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention4Active == true && InventionClass.isInvention3Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image4.color = Color.green;
            
            InventionClass.isInvention4Active = false;
            InventionClass.isInvention4Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention5Active == true && InventionClass.isInvention4Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image5.color = Color.green;

            InventionClass.isInvention5Active = false;
            InventionClass.isInvention5Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention6Active == true && InventionClass.isInvention5Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image6.color = Color.green;

            InventionClass.isInvention6Active = false;
            InventionClass.isInvention6Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention7Active == true && InventionClass.isInvention6Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image7.color = Color.green;

            InventionClass.isInvention7Active = false;
            InventionClass.isInvention7Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention8Active == true && InventionClass.isInvention7Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image8.color = Color.green;

            InventionClass.isInvention8Active = false;
            InventionClass.isInvention8Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention9Active == true && InventionClass.isInvention8Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image9.color = Color.green;

            InventionClass.isInvention9Active = false;
            InventionClass.isInvention9Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention10Active == true && InventionClass.isInvention9Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image10.color = Color.green;

            InventionClass.isInvention10Active = false;
            InventionClass.isInvention10Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention11Active == true && InventionClass.isInvention10Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image11.color = Color.green;

            InventionClass.isInvention11Active = false;
            InventionClass.isInvention11Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention12Active == true && InventionClass.isInvention11Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image12.color = Color.green;

            InventionClass.isInvention12Active = false;
            InventionClass.isInvention12Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention13Active == true && InventionClass.isInvention12Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image13.color = Color.green;

            InventionClass.isInvention13Active = false;
            InventionClass.isInvention13Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention14Active == true && InventionClass.isInvention13Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image14.color = Color.green;

            InventionClass.isInvention14Active = false;
            InventionClass.isInvention14Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention15Active == true && InventionClass.isInvention14Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image15.color = Color.green;

            InventionClass.isInvention15Active = false;
            InventionClass.isInvention15Exist = true;
            CraftedOrNot.text = "Use";
        }
        else if (InventionClass.isInvention16Active == true && InventionClass.isInvention15Exist)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image16.color = Color.green;

            InventionClass.isInvention16Active = false;
            InventionClass.isInvention16Exist = true;
            CraftedOrNot.text = "Use";
        }
    }
}
