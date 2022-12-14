using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject munition;
    private bool canShoot = false;

    public float delaySpawn = 5f;
    public float repeatSpawn = 2f;


     private int daņoAcumulado = 0; // lo va a decir en consola.
     public int daņoPorBola = 1;


    void Start()
    {
        InvokeRepeating("Shoot", delaySpawn, repeatSpawn);
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        if (canShoot)
        {
            canShoot = false;
            Instantiate(munition, transform);
            
             Damage();
           
             
             Invoke("ResetShoot", 1f);
            

        }
    }

    public void ResetShoot()
    {
        canShoot = true;
    }

      private void Damage()
     {
        daņoAcumulado = daņoPorBola + daņoAcumulado;
     }

    public void DesactivarCannon()
    {
        canShoot = false;
    }
    
}
