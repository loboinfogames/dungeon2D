using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerPos : MonoBehaviour
{
    private spawner sp;
    void Start()
    {
        sp = GameObject.FindGameObjectsWithTag("sp").GetComponent<spawner>();
        transform.position = sp.lastCheckPointPos;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }   
    }
}
