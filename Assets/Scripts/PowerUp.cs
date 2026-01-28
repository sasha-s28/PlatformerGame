using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerJumper playerJumper = collision.GetComponent<PlayerJumper>();
        if (playerJumper != null)
        {
            playerJumper.EnableDoubleJump();
            Destroy(gameObject);
        }
    }
}
