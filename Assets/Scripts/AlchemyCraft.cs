using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyCraft : MonoBehaviour
{
    public void MakePotion1()
    {
        if (HerbClass.Herb1Quantity >=2)
        {
            HerbClass.Herb1Quantity -= 2;
            PotionClass.Potion1Quantity += 1;
            ClassPlayer.AlchemyExperience += ReturnExp(ClassPlayer.AlchemyLevel);
            Debug.Log("SUKCES");
        }
    }
    public void MakePotion2()
    {
        if ((HerbClass.Herb1Quantity >0) &&(HerbClass.Herb2Quantity >0))
        {
            HerbClass.Herb1Quantity -= 1;
            HerbClass.Herb2Quantity -= 1;
            PotionClass.Potion2Quantity += 1;
            ClassPlayer.AlchemyExperience += ReturnExp(ClassPlayer.AlchemyLevel);
            Debug.Log("SUKCES");
        }
    }
    public void MakePotion3()
    {
        if ((HerbClass.Herb3Quantity > 0) && (HerbClass.Herb4Quantity > 0))
        {
            HerbClass.Herb3Quantity -= 1;
            HerbClass.Herb4Quantity -= 1;
            PotionClass.Potion3Quantity += 1;
            ClassPlayer.AlchemyExperience += ReturnExp(ClassPlayer.AlchemyLevel);
            Debug.Log("SUKCES");
        }
    }
    public void MakePotion4()
    {
        if ((HerbClass.Herb5Quantity > 0) && (HerbClass.Herb6Quantity > 0))
        {
            HerbClass.Herb5Quantity -= 1;
            HerbClass.Herb6Quantity -= 1;
            PotionClass.Potion4Quantity += 1;
            ClassPlayer.AlchemyExperience += ReturnExp(ClassPlayer.AlchemyLevel);
            Debug.Log("SUKCES");
        }
    }

    public int ReturnExp(int returnExp)
    {
        if (returnExp < 3 )
            return 2;
        else if (returnExp >= 3 && returnExp <6 )
            return 1;
        else
        {
            return 0;
        }
    }

}
