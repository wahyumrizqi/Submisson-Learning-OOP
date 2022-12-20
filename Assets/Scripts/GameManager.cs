using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string playerName;

    private void Awake()
    {
        if(instance != null)
        {
            DestroyObject(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

   
}
