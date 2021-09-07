using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class dusman : MonoBehaviour
{
    public NavMeshAgent dusmanimiz;
    Transform oyuncumuz;
    

    //oyuncunun pozisyonu transform içinde.
   
    void Start()
    {
        oyuncumuz = GameObject.Find("oyuncu").transform;
    }

    
    void Update()//sürekli takip etmesi için buranýn içine yazýyoruz.
    {
        dusmanimiz.destination = oyuncumuz.position;
        dusmanimiz.stoppingDistance = 1.2f;

    }
}
