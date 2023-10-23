using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject myObject;
    public TextMeshProUGUI textField;
    // Start is called before the first frame update
    public void Start()
    {
        myObject.SetActive(false);
    }
    public void Show()
    {
      
        myObject.SetActive(true);
        
        
    }


}
