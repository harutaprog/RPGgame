using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character
{
    //キャラクターの名前
    public string CharacterName;

    //体力・攻撃力・防御力の基本値
    [Range(0,99999)]
    public int HP;
    [Range(0,9999)]
    public int ATK;
    [Range(0,9999)]
    public int DEF;

    //戦闘中などに変動した体力・攻撃力・防御力の値
    [Range(0, 99999)]
    public int NowHP;
    [Range(0, 9999)]
    public int NowATK;
    [Range(0, 9999)]
    public int NowDEF;

    //設定されている基本アクション
    public UnityEvent[] Actions = new UnityEvent[6];

    //かかっている状態異常のリスト
    [SerializeField]
    public List<Condition.conditionStruct> conditionLists;
}