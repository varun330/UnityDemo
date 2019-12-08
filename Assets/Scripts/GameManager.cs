using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;
    public Text text;
    public GameObject gameOverUI;
    public CubeScript cube;
    public ObstacleSpawn spawn;
    public Score score;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            cube.enabled=false;
            score.enabled = false;
            spawn.CancelInvoke();
            text.text="Score: " +score.score;
            gameOverUI.SetActive(true);
            
        }
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
