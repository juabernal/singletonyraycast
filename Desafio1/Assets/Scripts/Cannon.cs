using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    public bool canShoot = true;

    public float delaySpawn = 5f;
    public float repeatSpawn = 2f;


     private int da�oAcumulado = 0; // lo va a decir en consola.
     public int da�oPorBola = 1;


    void Start()
    {
        InvokeRepeating("Shoot", delaySpawn, repeatSpawn);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            
             Damage();
           
             
             Invoke("ResetShoot", 1f);
            

        }
    }

    private void ResetShoot()
    {
        canShoot = true;
    }

      private void Damage()
     {
        da�oAcumulado = da�oPorBola + da�oAcumulado;
     }

    
}
