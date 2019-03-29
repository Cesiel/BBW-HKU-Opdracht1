using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public Animation Dead;
    public AudioClip sound;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Dead.Play();
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }
}
