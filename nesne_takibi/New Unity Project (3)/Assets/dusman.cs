using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dusman : MonoBehaviour
{
    public NavMeshAgent dusmanimiz;
    Transform oyuncumuz;
    

    //oyuncunun pozisyonu transform i�inde.
   
    void Start()
    {
        oyuncumuz = GameObject.Find("oyuncu").transform;
    }

    
    void Update()//s�rekli takip etmesi i�in buran�n i�ine yaz�yoruz.
    {
        dusmanimiz.destination = oyuncumuz.position;
        dusmanimiz.stoppingDistance = 1.2f;

    }
}
