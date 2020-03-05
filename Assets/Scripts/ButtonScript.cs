using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update

    public void RestartGame()
    {
        gameManager.restart();
    }

    public void Quit()
    {
        //eruyfgsufw
        Application.Quit();
    }
}
