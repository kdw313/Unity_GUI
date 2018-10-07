using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Main menu.
/// </summary>
public class MainMenu : MonoBehaviour {

    /// <summary>
    /// Plaies the game.
    /// </summary>
    public void PlayGame()
    {
        // TODO: Load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Quits the game.
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

}
