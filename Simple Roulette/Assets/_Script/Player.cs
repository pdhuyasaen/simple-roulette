using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit
{
    protected static Player instance;
    private Player()
    {
        
    }

    public static Player Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Player>();
                if (instance == null)
                {
                    var obj = new GameObject();
                    instance = obj.AddComponent<Player>();
                }
            }

            return instance;
        }
    }
}
