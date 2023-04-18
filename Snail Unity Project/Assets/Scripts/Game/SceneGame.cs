using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneGame : MonoBehaviour
{
    public TextMeshProUGUI [] displayPlayerName;
    [SerializeField] int playerIndex;

    public void Awake()
    {
        
        Debug.Log(SceneSetupScreen.playerName[playerIndex]);

        for (int i = 0; i < displayPlayerName.Length; i++)
        {
            displayPlayerName[i].text = SceneSetupScreen.playerName[i];
        }
    }
}
