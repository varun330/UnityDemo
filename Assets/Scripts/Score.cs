using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform cube;
    public Text text;
    public int score=0;
    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + score++; 
    }
}
