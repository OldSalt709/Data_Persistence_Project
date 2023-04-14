using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private string input;

    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }


}
