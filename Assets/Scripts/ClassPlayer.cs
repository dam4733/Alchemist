using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ClassPlayer 
{
    // Start is called before the first frame update
    public static string UtworzenieGracza { get;
        set;
    }
    public static int LevelOFPlayer { get; set; }

    public static int Gold {  get; set; }

    public static int NumberOfEvents { get; set; }

    public static int AlchemyLevel { get; set; }
    public static int AlchemyExperience { get; set; }
    public static int InventionLevel { get; set; }
    public static int InventionExperience { get; set; }

    public static float ActionPoints { get; set; }

    public static bool Action {  get; set; }

    public static bool CountingAction { get; set; }
    public static bool? CountingInProgressFlag{ get; set; }

    static ClassPlayer()
    {
        UtworzenieGracza = string.Empty;
        LevelOFPlayer = 1;
        Gold = 50;
        NumberOfEvents = 0;
        AlchemyLevel = 1;
        AlchemyExperience = 0;
        InventionLevel = 1;
        InventionExperience = 0;
        ActionPoints = 10;
        Action = true;
        CountingInProgressFlag = false;
    }
    
}
