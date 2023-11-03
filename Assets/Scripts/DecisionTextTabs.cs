using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class DecisionTextTabs 
{
    // Start is called before the first frame update

    public string[] EventDialog = {
             "here is the lorem ipsum decision lorem ipsum no.1"
            ,"here is the lorem ipsum decision lorem ipsum no.2"
            ,"here is the lorem ipsum decision lorem ipsum no.3"
            ,"here is the lorem ipsum decision lorem ipsum no.4"
            ,"here is the lorem ipsum decision lorem ipsum no.5"
            ,"here is the lorem ipsum decision lorem ipsum no.6"
            ,"here is the lorem ipsum decision lorem ipsum no.7"
            ,"here is the lorem ipsum decision lorem ipsum no.8"
            ,"here is the lorem ipsum decision lorem ipsum no.9"
            ,"here is the lorem ipsum decision lorem ipsum no.10"};

    public string[] Decision1Dialog = {
        " +herb",
        " +herb",
        "Gold +3",
        "Gold +4",
        "Gold +5",
        "Gold +6",
        "Gold +7",
        "Gold +8",
        "Gold +9",
        "Gold +10"
    };
    public string[] Decision2Dialog = {
        " -herb",
        " -herb",
        "Gold -3",
        "Gold -4",
        "Gold -5",
        "Gold -6",
        "Gold -7",
        "Gold -8",
        "Gold -9",
        "Gold -10"
    };
    public string[] BadEventHighFinance =
    {
        "high finance",
        "high finance",
        "high finance",
        "high finance",
        "high finance",
        "high finance",
        "high finance",
        "high finance",
        "high finance",
        "high finance",


    };
    public string[] BadDecision1HighFinance =
   {
        "high1 ",
        "high3",
        "high5 ",
        "high7 ",
        "high9 ",
        "high11 ",
        "high13 ",
        "high15 ",
        "high17 ",
        "high19 ",


    };
    public string[] BadDecision2HighFinance =
  {
        "high2 ",
        "high2",
        "high2 ",
        "high2 ",
        "high2 ",
        "high2 ",
        "high2 ",
        "high2 ",
        "high2 ",
        "high2 ",


    };


    public DecisionTextTabs() {
      
        
    }
}
