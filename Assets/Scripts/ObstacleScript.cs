using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    // Update is called once per frame
    Rigidbody cube;
    Transform self;
    public float xPos;
    public float yPos;
    public float zPos;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        cube = GameObject.FindWithTag("Player").GetComponent<Rigidbody>(); ;
        self = GetComponent<Transform>();
        SpawnObject();
    }
    void Update()
    {
        int factor = (gameManager.score.score / 1500)+1;
        transform.Translate(0f, 0f, -10f*factor*Time.deltaTime);
        
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
