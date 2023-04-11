using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings 
{
    public int minMapSize;
    public int maxMapSize;

    //constructor
    public PlayerSettings(int min, int max)
    {
        minMapSize = min;
        maxMapSize = max;
    }

    
}
