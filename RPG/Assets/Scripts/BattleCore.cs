using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BattleCore : MonoBehaviour
{
    public List<Player> players;
    public List<Enemy> enemies;
    public EnemyList enemyList;
    public Action action;
    public delegate void Del<T1,T2>(List<T1> attackSide, int attackChar, List<T2> defenceSide, int defenceChar);
    public int targetEnemy;
    // Start is called before the first frame update
    void Start()
    {
        Del<Player,Enemy> del = action.Attack;
        enemies.Add(enemyList.enemyList[0]);
        enemies[0].NowHP = enemies[0].HP;
        del(players, 0, enemies, 0);
//        action.Attack(players, 0, enemies, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}