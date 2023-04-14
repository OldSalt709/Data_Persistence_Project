using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class UIPlayerDetails : MonoBehaviour
{
    public string playerName;
    public TMP_InputField inputField;

    public void SavePlayerName()
    {
        if (inputField != null)
        {
            playerName = inputField.text;
            MainManager.Instance.playerName = playerName;
        }
    }


    /*
    public TextMeshProUGUI player_Name;
    string input;

    public void StorePlayerName(string inputName)
    {
        // store player
        
        Debug.Log(player_Name);

        MainManager.Instance.playerName = inputName;

    }
    */
}
