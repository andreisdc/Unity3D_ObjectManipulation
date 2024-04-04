using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] private float _gravity = 9.81f; // Gravitatea standard pe Pământ
    [SerializeField] private float _terminalVelocity = 50f; // Viteza maximă către care poate ajunge obiectul în cădere

    private bool _isGrounded = false;

    private void Update()
    {
        ApplyGravity();
    }

    private void ApplyGravity()
    {
        Vector3 gravityVector = Vector3.down * _gravity * Time.deltaTime;

        if (_isGrounded)
        {
            // Dacă suntem la sol, nu mai aplicăm gravitatea
            return;
        }

        transform.position += gravityVector;

        if (gravityVector.magnitude > _terminalVelocity * Time.deltaTime)
        {
            transform.position += gravityVector.normalized * _terminalVelocity * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plane"))
        {
            _isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plane"))
        {
            _isGrounded = false;
        }
    }
}
