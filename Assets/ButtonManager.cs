using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonManager : MonoBehaviour
{

    public void StartGameBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
    public void OptionsBtn(string optionsButton)
    {
        SceneManager.LoadScene(optionsButton);
    }

    public void VolumeBtn(string volumeButton)
    {
        SceneManager.LoadScene(volumeButton);
    }

    public void BackBtn(string backButton)
    {
        SceneManager.LoadScene(backButton);
    }
    public void ExitGameBtn()
    {
        Application.Quit();
        PlayerPrefs.DeleteKey("Level_win");
    }

    public void RestartBtn(string restartBtn)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
