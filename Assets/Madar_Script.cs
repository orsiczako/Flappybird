using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Madar_Script : MonoBehaviour
{
    public Rigidbody2D rigidbodym;
    public float csapasErosseg;
    public Szamolo_script szamol;
    
    public bool eletbenvan=true;

    // Start is called before the first frame update
    void Start()
    {
        //Ez megváltoztatja a nevét 
        /*gameObject.name="Madarnev";*/
        szamol=GameObject.FindGameObjectWithTag("Szamol").GetComponent<Szamolo_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Megadjuk merre menjen, ezt amúgy vektorokkal is meg lehet adni
        if((Input.GetKeyDown(KeyCode.Space)==true || Input.GetKeyDown(KeyCode.UpArrow)==true) && eletbenvan==true)
        {
            rigidbodym.velocity=Vector2.up*csapasErosseg;

        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        szamol.vege();
        eletbenvan=false;
    }
}
