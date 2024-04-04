using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public float gravityScale = 1f; 
    public bool inPlayer = false;
    private Rigidbody rb;
    private EnemyCharacter enemyScript;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Au");
            inPlayer = true;
            enemyScript = collider.gameObject.GetComponent<EnemyCharacter>();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        inPlayer = false; 
        enemyScript = null;
    }


    void Update()
    {
        if (inPlayer && Input.GetKeyDown(KeyCode.Space) && enemyScript != null)
        {
            enemyScript.TakeDamage(10);
            Vector3 direction = transform.position - enemyScript.transform.position;
            direction.Normalize();
            float distanceToMove = 4.0f; // Definim o distanță arbitrară pentru a muta inamicul înapoi, poți ajusta după nevoie
            float yOffset = 1.0f; // Definim o valoare pentru a muta inamicul în sus
            Vector3 newPosition = enemyScript.transform.position + direction * distanceToMove;
            newPosition.y += yOffset; // Adăugăm offsetul pe coordonata Y
            enemyScript.transform.position = newPosition;
        }
    }
}
    