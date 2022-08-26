using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayast : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [Range(1, 50f)]

    
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
        if (Physics.Raycast(shootPoint.position,Vector3.forward,out hit, rayDistance))
        {
            if (hit.transform.CompareTag("Player"))
            {
                Debug.Log("Colisión");
            }
        }
    }

}

