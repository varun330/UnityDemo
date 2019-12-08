using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Update is called once per frame
    Rigidbody cube;
    Transform self;
    public float xPos;
    public float yPos;
    public float zPos;

    private void Start()
    {
        cube = GameObject.FindWithTag("Player").GetComponent<Rigidbody>(); ;
        self = GetComponent<Transform>();
        SpawnObject();
    }
    void Update()
    {
        transform.Translate(0f, 0f, -.125f);
        
        if (cube.position.z > transform.position.z+10)
            Destroy(gameObject);
    }
    public void SpawnObject()
    {
        xPos = Random.Range(-3, 3);
        yPos = Random.Range(0, 2);
        zPos = cube.transform.position.z + 50;
        self.position = self.position + new Vector3(xPos, yPos, zPos);
    }
}
