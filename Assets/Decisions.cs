using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Decisions : MonoBehaviour
{
    public TextMeshProUGUI textField;
    // Start is called before the first frame update
    public int Rand()
    {

        var number = Random.Range(0, 10);
        return number;
        
    }
    public void DisplayDecision()
    {

       // textField.text =
      string filePath = "Assets/Dialogs.txt"; // WprowadŸ œcie¿kê do pliku txt


        int lineNumber = Rand(); // podaj numer linii do odczytania (licz¹c od zera)

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lineNumber < lines.Length)
            {
                string specificLine = lines[lineNumber];
                textField.text = specificLine;
            }
            else
            {
                Debug.Log("Podany numer linii przekracza iloœæ linii w pliku.");
            }
        }
        else
        {
            Debug.Log("Plik nie istnieje.");
        }
    }
    
    /*public void Start()
    {
        DisplayDecision();
        
    }*/
    

}
