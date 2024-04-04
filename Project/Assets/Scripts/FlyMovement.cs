using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyMovement : MonoBehaviour
{
    public float flySpeed = 5f;
    public float jumpForce = 10f; 

    public SoundManager soundManager; 

    Rigidbody rb;
    int countJump = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle") || other.gameObject.CompareTag("Planet"))
        {
            soundManager.PlayCollisionSound();
            SceneManager.LoadScene("Scenes/Lab4/Lab4");
        }
        else if (other.gameObject.CompareTag("Fuel"))
        {
            countJump = 2;
            Destroy(other.gameObject);
        }
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && countJump > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            countJump--;
            soundManager.PlayJumpSound();
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * flySpeed * Time.deltaTime);
        }
    }
}