using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayast : MonoBehaviour
{
    // Si toca este Raycast activa el disparo del ca?on.
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform endPoint;

    
    //Lectura de Script Ca?on para traer la variable canShoot y Activar/desactivar
    Cannon canShootr;

    [SerializeField] private float rayDistance = 10;

    void Start()
    {

    }


    void Update()
    {
        CannonRaycast();

    }

    private void CannonRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootPoint.position, endPoint.localPosition, out hit, rayDistance))
        {
            if (hit.transform.CompareTag("Player"))
            {

                canShootr = GameObject.FindGameObjectWithTag("cannon").GetComponent<Cannon>();
                canShootr.ResetShoot();

                Debug.Log("Colisi?n con Player");
            }

        }

        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(shootPoint.position, endPoint.position);
    }

}

