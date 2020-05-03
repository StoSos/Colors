using UnityEngine;

public class Enemygivedamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();
        playerHealth.TakeDamage(10);
    }
}
