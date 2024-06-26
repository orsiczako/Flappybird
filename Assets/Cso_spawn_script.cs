using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cso_spawn_script : MonoBehaviour
{
    public GameObject Csovek;
    public float spawnRate=2;
    public float ido =0;
    public float magassag=10;
    void Start()
    {
        //Azért tettük be ide, hogy egyből spawnolja a csöveket
        spawnCso();
    }

    // Update is called once per frame
    void Update()
    {
        if (ido<spawnRate)
        {
            ido=ido+Time.deltaTime;
        }
        else
        {
            spawnCso();
            ido=0;
        }
        
    }
    void spawnCso()
    {
        float alacsonyabbPont=transform.position.y-magassag;
        float magasabbPont=transform.position.y+magassag;
        Instantiate(Csovek,new Vector3(transform.position.x,Random.Range(alacsonyabbPont,magasabbPont),0),transform.rotation);
        
    }
}
