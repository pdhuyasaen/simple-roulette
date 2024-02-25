using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bot : Unit
{
    private static Bot instance;
    private Bot()
    {

    }

    public static Bot GetInstance()
    {
        if (instance == null)
        {
            instance = new Bot();
        }
        return instance;
    }

}
