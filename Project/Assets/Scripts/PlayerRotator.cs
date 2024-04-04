using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    [SerializeField] private float _RotationSpeed = 100f;

    void Update()
    {
        // Rotatie pe OX la apasarea tastei X
        if (Input.GetKey(KeyCode.X))
        {
            float rotationAmountX = _RotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, rotationAmountX);
        }

        // Rotatie pe OY la apasarea tastei Y
        if (Input.GetKey(KeyCode.Y))
        {
            float rotationAmountY = _RotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotationAmountY);
        }

        // Rotatie pe OZ la apasarea tastei Z
        if (Input.GetKey(KeyCode.Z))
        {
            float rotationAmountZ = _RotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, rotationAmountZ);
        }
    }
}
