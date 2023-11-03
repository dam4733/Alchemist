using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PotionClass
{
    // Start is called before the first frame update

    public static int Potion1Quantity { get; set; }
    public static int Potion2Quantity { get; set; }
    public static int Potion3Quantity { get; set; }
    public static int Potion4Quantity { get; set; }

    static PotionClass()
        {
        Potion1Quantity = 0;
        Potion2Quantity = 0;
        Potion3Quantity = 0;
        Potion4Quantity = 0;
        }
}
