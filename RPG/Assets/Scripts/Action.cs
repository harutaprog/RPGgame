using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Action : ScriptableObject
{
    //attackSide    攻撃するキャラクターが属するリスト
    //attackChar    攻撃するキャラクターの番号(0の場合全体攻撃)
    //defenceSide   受けるキャラクターが属するリスト
    //defenceChar   受けるキャラクターの番号(0の場合全体攻撃)
    public void Attack<T1,T2>(List<T1> attackSide,int attackChar,List<T2> defenceSide, int defenceChar)
        where T1 : Character
        where T2 : Character
    {
        Debug.Log("kita");
        defenceSide[defenceChar].NowHP -= attackSide[attackChar].NowATK;
    }
}
