using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public Player player => Player.GetInstance();
    public Bot bot => Bot.GetInstance();

    public RoundController roundController => RoundController.Instance;
    

    // Start is called before the first frame update
    void Start()
    {
        LevelStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameStart()
    {

    }

    void LevelStart(/*int level*/)
    {
        player.OnStartLevel();
        bot.OnStartLevel();
        NextRound();
    }

    void NextRound()
    {
        roundController.OnStartRound();
    }

    void NextTurn()
    {

    }

    
}
