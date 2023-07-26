using UnityEngine;
using UnityEngine.SceneManagement;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

/*
 * Small behaviour to handle menu button callbacks.
 */
public class MenuController : MonoBehaviour
{
    //record the level
    private int level;
    
    //Jump to Choose Level Scene
    public void OnChooseLevelClicked()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

    //If choose one level, record and jump to the level
    public void OnLevelClicked(int l)
    {
        PlayerPrefs.SetInt("level", l);
        SceneManager.LoadScene("Level_" + l);
    }

    //Back to the Menu Scene
    public void OnBackClicked()
    {
        SceneManager.LoadScene("Menu");
    }

    //Get the current level and restart
    public void OnRestartClicked()
    {
        level = PlayerPrefs.GetInt("level");
        SceneManager.LoadScene("Level_" + level);
    }

    //Jump to next level
    public void OnNextLevelClicked()
    {
        level = PlayerPrefs.GetInt("level") + 1;
        //if all level is over, jump to finish scene
        if(level > 4)
        {
            SceneManager.LoadScene("Finish");
        }
        else
        {
            PlayerPrefs.SetInt("level", level);
            SceneManager.LoadScene("Level_" + level);
        }
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
