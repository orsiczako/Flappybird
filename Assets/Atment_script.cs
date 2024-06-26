using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Atment_script : MonoBehaviour
{
    public Szamolo_script szamol;
    // Start is called before the first frame update
    
    void Start()
    {
        
        szamol=GameObject.FindGameObjectWithTag("Szamol").GetComponent<Szamolo_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       
        szamol.Noveles();
        
    }
}
