
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public AudioSource hitSound;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            hitSound.Play();
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
