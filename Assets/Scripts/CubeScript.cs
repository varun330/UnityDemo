using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody.AddForce(0f, 0f, 500 * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime*10,0f,0f);
        transform.Translate(0f, Input.GetAxis("Vertical")*10 * Time.deltaTime, 0f);

        if (rigidbody.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
