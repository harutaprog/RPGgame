using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyList : ScriptableObject
{
    public List<Enemy> enemyList = new List<Enemy>();
}

[System.Serializable]
public class Enemy : Character
{
    //倒すことで入手できるお金
    public int money;
}