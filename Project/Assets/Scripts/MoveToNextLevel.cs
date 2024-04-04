using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{

    [SerializeField] private string NextLevel;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(NextLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
