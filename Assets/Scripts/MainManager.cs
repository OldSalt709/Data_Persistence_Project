using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    //  Variables for current session
    public string playerName;
    public int currentScore;

    //  Variables for High Score session
    public string highScoreName;
    public int highScore;


    private void Awake()
    {
        //  if there are 2 MainManagers in scene, destroy this MainManager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        } 

        //  But if this is the only one, don't destroy it
        Instance = this;

        DontDestroyOnLoad(gameObject);

        // Do this or the code won't know a high score even exists in MainManager
        LoadHighScore();

    }

    [System.Serializable]
    public class SaveData
    {
        public int highScore;
        public string highScoreName;

    }

    //  capturing two elements to display
    public void SaveHighScore(int currentScore, string playerName)
    {
        //  first create a new instance of the save date
        SaveData data = new SaveData();

        //  then specify what you want to store
        data.highScore = currentScore;
        data.highScoreName = playerName;

        // next transform that instance to JSON with JsonUtility.ToJson
        string json = JsonUtility.ToJson(data);

        //  Finally, use the special method File,WriteToAllText to write a string to a file
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.highScore;
            highScoreName = data.highScoreName;

        }
    }

}
