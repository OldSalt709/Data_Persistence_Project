using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBestScore : MonoBehaviour
{

    public Text bestScore_Text;

    // Start is called before the first frame update
    void Start()
    {
        //  Load High SCore
        //  If I don't this script won't know where to pull from
        MainManager.Instance.LoadHighScore();

        Debug.Log("High score is " + MainManager.Instance.highScore);

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
            bestScore_Text.text = "Hello, set a High Score";
        }

    }

    void DisplayHighScore()
    {
        bestScore_Text.text = MainManager.Instance.playerName + ", can you beat " + MainManager.Instance.highScore + " set by " + MainManager.Instance.highScoreName;

    }

    void DisplayName()
    {
        bestScore_Text.text = MainManager.Instance.playerName + ", set a High Score!";

    }
}
