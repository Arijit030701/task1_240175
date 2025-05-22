using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playermovement;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacles")
        {
            audioSource2.Play();
            gameController.GameOver();
            playermovement.enabled = false;
        }
    }
}
