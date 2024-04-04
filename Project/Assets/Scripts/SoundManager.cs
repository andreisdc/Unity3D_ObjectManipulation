using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip jumpSound;
    public AudioClip collisionSound;
    public AudioClip powerupSound;
    
    private AudioSource audioSource;

    void Awake()
    {
        
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        PlaySound(jumpSound);
    }

    public void PlayCollisionSound()
    {
        PlaySound(collisionSound);
    }

    public void PlayPowerupSound()
    {
        PlaySound(powerupSound);
    }

    void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.clip = clip;
            audioSource.Play();
        }
    }
}