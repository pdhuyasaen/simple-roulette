using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int hp = 2;
    int level_HP => hp;
    int current_HP;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnStartLevel()
    {
        current_HP = level_HP;
    }

    public virtual bool CheckDead()
    {
        return current_HP <= 0 ? true : false;
    }

    public void TakeDamage(int damage)
    {
        current_HP -= damage;
        CheckDead();
    }

}
