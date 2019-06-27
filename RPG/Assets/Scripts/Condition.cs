using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condition : MonoBehaviour
{
    [System.Serializable]
    public enum conditionName
    {
        毒,
        麻痺,
        気絶,
        攻撃力上昇,
        防御力上昇,
        攻撃力低下,
        防御力低下,
    }

    [System.Serializable]
    public class conditionStruct
    {
        //かかっている状態異常の名前(これでかかっている状態異常を識別する)
        public conditionName name;
        //残りターン数
        public int turn;
        //効果量(攻撃上昇&低下など限定)
        public int value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}