using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public string CharacterName;

    public int HP;
    public int ATK;
    public int DEF;

    public int NowHP;
    public int NowATK;
    public int NowDEF;

    public UnityEvent[] Actions = new UnityEvent[6];

    [SerializeField]
    public List<Condition.conditionStruct> conditionLists;
}
