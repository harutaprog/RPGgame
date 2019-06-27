using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCore : MonoBehaviour
{
    public List<Player> players;
    public List<Enemy> enemies;
    public EnemyList enemyList;
    public Action action;

    public int targetEnemy;
    // Start is called before the first frame update
    void Start()
    {
        enemies.Add(enemyList.enemyList[0]);
        enemies[0].NowHP = enemies[0].HP;
        action.Attack<Player,Enemy>(players, 0, enemies, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}