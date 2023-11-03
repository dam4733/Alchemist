using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateInvention1 : MonoBehaviour
{
    public Button button;
    public RawImage image;
    // Start is called before the first frame update
    public void Create()
    {
        Debug.Log(InventionClass.isInvention1Active);
        if (InventionClass.isInvention1Active == true)
        {
            StoneClass.Stone1Quantity -= 1;
            StoneClass.Stone2Quantity -= 2;
            image.color = Color.green;
            Debug.Log("Zmieniono");
            InventionClass.isInvention1Active = false;
        }
    }
}
