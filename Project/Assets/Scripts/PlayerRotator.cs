using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{

    [SerializeField] private float _RotationSpeed = 100f;

    void Update()
    {
        // Rotatie pe OX la miscarea orizontala
        float horizontalRotation = Input.GetAxis("Horizontal");
        if (horizontalRotation != 0)
        {
            float rotationAmountX = horizontalRotation * _RotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.right, rotationAmountX);
        }

        // Rotatie pe OY la miscarea verticala
        float verticalRotation = Input.GetAxis("Vertical");
        if (verticalRotation != 0)
        {
            float rotationAmountY = verticalRotation * _RotationSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotationAmountY);
        }
    }
}
