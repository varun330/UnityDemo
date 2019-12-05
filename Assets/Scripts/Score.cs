using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform cube;
    public Text text;
    // Update is called once per frame
    void Update()
    {
        text.text = "Score: " + cube.position.z.ToString("0"); 
    }
}
