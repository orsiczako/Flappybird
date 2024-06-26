using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Szamolo_script : MonoBehaviour
{
    public int pontszam;
    public Text pontszamText;
    public GameObject gameOver;


    [ContextMenu("Pontszám megnövelve")]
    public void Noveles()
    {
        pontszam++;
        pontszamText.text=pontszam.ToString();
    }

    public void ujrakezdes()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void vege()
    {
        gameOver.SetActive(true);
    }
    
}
