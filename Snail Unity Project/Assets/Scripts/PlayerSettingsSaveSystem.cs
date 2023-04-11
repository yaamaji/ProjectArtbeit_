using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerSettingsSaveSystem : MonoBehaviour
{
    //Speicherplatz der nicht aufgefüllt ist
    PlayerSettings playerSettings;


    private void Start()
    {
        playerSettings = new PlayerSettings(1,10);

        SaveFile();

    }

    void SaveFile() //Methode
    {
        string json = JsonUtility.ToJson(playerSettings);
        string path = Application.streamingAssetsPath + "/PlayerSettings" + "/playerSettingsSettings.json";
        StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.Write(json);
        streamWriter.Close();

    }
}
