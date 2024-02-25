using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    private static Player instance;
    private Player()
    {
        
    }

    public static Player GetInstance()
    {
        if (instance == null)
        {
            instance = new Player();
        }
        return instance;
    }

}
