using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public CubeScript cube;

    public void CompleteLevel()
    {
        Debug.Log("Level Won");
        cube.enabled = false;
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            cube.enabled=false;
            gameOverUI.SetActive(true);
            Invoke("restart",restartDelay);
            
        }
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
