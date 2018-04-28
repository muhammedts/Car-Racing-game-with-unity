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
    public void PlayAgain()
    {
        LapComplete.lapsDone = 0;
        SceneManager.LoadScene("road asmaa and moaaz");
    }
    public void PlayAgain2()
    {
        LapComplete.lapsDone = 0;
        SceneManager.LoadScene("Track");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
