using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public void StartTheGame() {
        Debug.Log("Button working");
        SceneManager.LoadScene("jerryScene");
        Debug.Log("The button is working.");
    }

    
}
