using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    public void LowDifficulty()
    {
        SceneManager.LoadScene("Track");
    }
    public void HighDifficulty()
    {
        SceneManager.LoadScene("road asmaa and moaaz");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
