using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public CubeScript cube;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            cube.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
