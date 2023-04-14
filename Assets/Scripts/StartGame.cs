using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public TextMeshProUGUI titleScore_text;

    private void Start()
    {
        titleScore_text.text = "Hello, enter your name to set a high score.";
        UpdateTitleScreenText();
    }
    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitTheApplication()
    {
        Application.Quit();
    }

    public void UpdateTitleScreenText()
    {
        if (MainManager.Instance != null)
        {
            if (MainManager.Instance.highScore != 0)
            {
                DisplayHighScore();
            }
            else
            {
                DisplayName();
            }
        }
        else
        {
            titleScore_text.text = "Hello, set a High Score";
        }

    }

    void DisplayHighScore()
    {
        titleScore_text.text = MainManager.Instance.playerName + ", can you beat " + MainManager.Instance.highScore + " set by " + MainManager.Instance.highScoreName;

    }

    void DisplayName()
    {
        if (MainManager.Instance != null)
        {
            if (MainManager.Instance.playerName != "")
            {
                titleScore_text.text = MainManager.Instance.playerName + " set a High Score";
            }
        }
    }
}
