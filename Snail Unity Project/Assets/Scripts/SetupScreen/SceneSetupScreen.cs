using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class SceneSetupScreen : MonoBehaviour
{
    public SceneSetupScreen scene1;
    public TMP_InputField[] inputFieldPlayer;

    public static string[] playerName;

    private void Awake()
    {
        if (scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        playerName = new string[2];
    }


}
