using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StoneClass 
{
    // Start is called before the first frame update
    public static int Stone1Quantity {  get; set; }
    public static int Stone2Quantity {  get; set; }
    public static int Stone3Quantity {  get; set; }
    public static int Stone4Quantity {  get; set; }

    

    static StoneClass ()
    {
        Stone1Quantity = 10;
        Stone2Quantity = 20;
        Stone3Quantity = 30;
        Stone4Quantity = 40;
    }
}
