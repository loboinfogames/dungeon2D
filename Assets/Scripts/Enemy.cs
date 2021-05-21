using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject OtherGameObject;
  
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
           // Destroy(OtherGameObject,2);
            Instantiate(OtherGameObject);
            /*for (int i = 0; i< 5; i++)
            {
                Instantiate(OtherGameObject);
            }*/
        }
    }
}
