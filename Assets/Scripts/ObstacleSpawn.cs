using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] prefabs;
    GameManager game_manager;

    // Update is called once per frame
    private void Start()
    {
        game_manager = FindObjectOfType<GameManager>();
        InvokeRepeating("SpawnObjects", 0f, 1f);
    }
    
    private void SpawnObjects()
    {
        float x = Random.Range(0, 5);
        int index = 0;
        if (x < 1)
            index = 0;
        else if (x < 2)
            index = 1;
        else if (x < 3)
            index = 2;
        else if (x < 4)
            index = 3;
        else
            index = 4;
        Instantiate(prefabs[index], new Vector3(0, 0, 0), Quaternion.identity);
    }
}
