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

    static ClassPlayer()
    {
        UtworzenieGracza = string.Empty;
        LevelOFPlayer = 1;
        Gold = 50;
    }
}
