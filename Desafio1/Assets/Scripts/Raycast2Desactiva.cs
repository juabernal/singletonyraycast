using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast2Desactiva : MonoBehaviour
{
    // Si toca este Raycast activa el disparo del cañon.
    [SerializeField] private Transform shootPoint2;
    [SerializeField] private Transform endPoint2;


    //Lectura de Script Cañon para traer la variable canShoot y Activar/desactivar
    Cannon canShootr;

    [SerializeField] private float rayDistance2 = 10;
    // Start is called before the first frame update
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
        if (Physics.Raycast(shootPoint2.position, endPoint2.localPosition, out hit, rayDistance2))
        {
            if (hit.transform.CompareTag("Player"))
            {

                canShootr = GameObject.FindGameObjectWithTag("cannon").GetComponent<Cannon>();
                canShootr.DesactivarCannon();

                Debug.Log("Desactivado");
            }

        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(shootPoint2.position, endPoint2.position);
    }
}
