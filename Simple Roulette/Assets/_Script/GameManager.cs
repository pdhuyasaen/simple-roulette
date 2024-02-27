using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player player => Player.Instance;
    public Bot bot => Bot.Instance;

    public RoundController roundController => RoundController.Instance;
    public UIManager uiManager => UIManager.Instance;
    public Gun gun => Gun.Instance;

    // Start is called before the first frame update
    void Start()
    {
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        uiManager.OnGameStart();
    }

    public void LevelStart(int level = 1)
    {
        player.OnStartLevel();
        bot.OnStartLevel();
        uiManager.OnLevelStart();

        NextRound();
    }

    public void NextRound()
    {
        roundController.OnStartRound();
        gun.OnStartRound(4);
    }

    public void NextTurn()
    {

    }

    public void OnShoot(Unit unitTarget)
    {
        var b = gun.OnShoot();
        unitTarget.TakeDamage(b.BulletState);
        Debug.Log(unitTarget.ToString()+" take damage "+ b.BulletState);
    }


}
