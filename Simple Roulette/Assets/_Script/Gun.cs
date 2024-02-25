using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Gun : Singleton<Gun>
{
    [SerializeField] private int maxAmount = 8;
    public int currentAmount;
    [SerializeField] public List<Bullet> bulletList = new List<Bullet>();

    // Start is called before the first frame update
    void Start()
    {   
        for(int i = 0; i < maxAmount; i++) 
        {
            bulletList.Add(new Bullet(false));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStartRound(int roundBullet)
    {
        bulletList.Clear();
        currentAmount = roundBullet;
        for(int i= 0; i<roundBullet; i++) 
        {
            //bulletList[i].SetupBullet(i < roundBullet);
            bulletList.Add(new Bullet(i<roundBullet));
        }
    }

    public void OnShoot()
    {
        Bullet shootedBullet = bulletList[bulletList.Count-1];
        Debug.Log(shootedBullet.BulletState);
        bulletList.RemoveAt(bulletList.Count-1);
    }

    public void OnCheck()
    {
        Bullet checkedBullet = bulletList[bulletList.Count - 1];
        Debug.Log(checkedBullet);  
    }

    public void OnDelay()
    {
        Bullet delayBullet = bulletList[bulletList.Count - 1];
        bulletList.RemoveAt(bulletList.Count - 1);
        bulletList.Insert(0, delayBullet);
    }
}
[Serializable]
public class Bullet
{
    //public BulletState state;
    public int BulletState;
    public Bullet(bool notEmpty)
    {
        //BulletState = notEmpty ? UnityEngine.Random.Range(1, 2) : 0;
        BulletState = (int)UnityEngine.Random.Range(0f, 2f);
    }
}