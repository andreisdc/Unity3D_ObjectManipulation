using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
 [SerializeField] private float _MovementSpeed = 5f;

    void Update()
    {
        // Deplasare la stânga
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * _MovementSpeed * Time.deltaTime);
        }

        // Deplasare la dreapta
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * _MovementSpeed * Time.deltaTime);
        }

        // Deplasare înainte
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * _MovementSpeed * Time.deltaTime);
        }

        // Deplasare înapoi
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * _MovementSpeed * Time.deltaTime);
        }

        // Deplasare în sus
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * _MovementSpeed * Time.deltaTime);
        }

        // Deplasare în jos
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.down * _MovementSpeed * Time.deltaTime);
        }
    }
}
