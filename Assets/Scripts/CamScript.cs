using UnityEngine;

public class CamScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cube;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = cube.position + offset;
    }
}
