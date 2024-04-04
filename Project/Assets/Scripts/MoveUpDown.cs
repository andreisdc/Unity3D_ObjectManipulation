using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    public float speed = 2.0f; // Viteza de mișcare în sus și în jos
    public float maxUp = 5.0f; // Poziția maximă în sus
    public float maxDown = -5.0f; // Poziția maximă în jos

    private void Update()
    {
        // Calculăm mișcarea pe axa Y
        float movement = Mathf.Sin(Time.time * speed);

        // Aplicăm mișcarea
        transform.position = new Vector3(transform.position.x, Mathf.Lerp(maxDown, maxUp, (movement + 1f) / 2f), transform.position.z);
    }
}