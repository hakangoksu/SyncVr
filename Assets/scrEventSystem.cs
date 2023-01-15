using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrEventSystem : MonoBehaviour
{

    public int Cherries;
    public Text scoreText;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    public void addScore()
    {
        Cherries += 1;
        scoreText.text = Cherries.ToString();
    }
    public void gameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
