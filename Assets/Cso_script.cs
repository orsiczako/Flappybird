using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cso_script : MonoBehaviour
{
    public float sebesseg;
    public float torlesZona =-40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+(Vector3.left*sebesseg)*Time.deltaTime;
        //Ezért kellett megszorozni, hogy minden fps-en ugyanolyan gyorsan menjen
        if(transform.position.x<torlesZona)
        {
            Debug.Log("Cső törölve");
            Destroy(gameObject);
        }
    }

}

