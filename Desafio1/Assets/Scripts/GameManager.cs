using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int VidaPlayer = 5;

    // esto de abajo entiendo que siempre se pone por las dudas que se repita el GameManager.
    public static GameManager instance;
    public bool dontDestroyOnLoad;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(gameObject);

            }
            else
            { Destroy(gameObject);
            }
        }    
    }

}
