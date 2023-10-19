using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{   
    public Canvas gameOverScreen;

    public void ResetTheGame() {
        gameOverScreen.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("The button is working.");
    }

    public void ReturnToMainMenu() {
        gameOverScreen.gameObject.SetActive(false);
        SceneManager.LoadScene("MenuScene");
        
    }
}
