using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MoveToAnotherScene : MonoBehaviour
{
    public void MoveToForest()
    {
        //ClassPlayer.LevelOFPlayer += 1;
        SceneManager.LoadScene(1);
    }
    public void MoveToLab()
    {
        
        SceneManager.LoadScene(0);
    }
    public void Rand()
    {
        
        var number =Random.Range(0, 10);
        Debug.Log(number);
    }
    public void ReadDialog()
    {
        string filePath = "Assets/Dialogs.txt"; // WprowadŸ œcie¿kê do pliku txt

        
        int lineNumber = 0; // podaj numer linii do odczytania (licz¹c od zera)

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lineNumber < lines.Length)
            {
                string specificLine = lines[lineNumber];
                Debug.Log("Odczytana linia: " + specificLine);
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

}
