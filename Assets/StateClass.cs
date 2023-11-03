using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StateClass 
{
    // Start is called before the first frame update
    public static int Finances {  get;  set; }
    public static int Stability {  get;  set; }
    public static int Order {  get;  set; }

    static StateClass()
    {
        Finances = 3;
        Stability = 3;
        Order = 3;
    }

}
