using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : MonoBehaviour
{
    public int health = 100; // Variabilă pentru viața inamicului
    void Start()
    {
        
    }
    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
