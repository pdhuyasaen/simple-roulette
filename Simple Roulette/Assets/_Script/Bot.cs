using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bot : Unit
{
    protected static Bot instance;
    private Bot()
    {

    }

    public static Bot Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Bot>();
                if (instance == null)
                {
                    var obj = new GameObject();
                    instance = obj.AddComponent<Bot>();
                }
            }

            return instance;
        }
    }

}
