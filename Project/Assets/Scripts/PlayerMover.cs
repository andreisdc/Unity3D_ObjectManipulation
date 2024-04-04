using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _MovementSpeed = 5f;

     void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * _MovementSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * _MovementSpeed * Time.deltaTime);
        }

    
    }
}
