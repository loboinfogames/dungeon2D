using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    private spawner sp;
    void Start()
    {
        sp = GameObject.FindGameObjectsWithTag("sp").GetComponent<spawner>();  
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sp.lastCheckPointPos = transform.position;
        }
    }
}
