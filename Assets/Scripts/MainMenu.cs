using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Button handlers for the main menu and the end-of-race screen.
/// The method names are wired to UI buttons in the scenes, so they must not be renamed.
/// </summary>
public class MainMenu : MonoBehaviour
{
    private const string MenuScene = "Menu";
    private const string EasyTrackScene = "Track";                // one AI opponent
    private const string HardTrackScene = "road asmaa and moaaz"; // town track, two AI opponents

    public void LowDifficulty()
    {
        Load(EasyTrackScene);
    }

    public void HighDifficulty()
    {
        Load(HardTrackScene);
    }

    public void PlayAgain()
    {
        Load(HardTrackScene);
    }

    public void PlayAgain2()
    {
        Load(EasyTrackScene);
    }

    public void MAinMenu()
    {
        Load(MenuScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private static void Load(string scene)
    {
        LapComplete.ResetAllLaps();
        LapTimeManager.ResetClock();
        SceneManager.LoadScene(scene);
    }
}
