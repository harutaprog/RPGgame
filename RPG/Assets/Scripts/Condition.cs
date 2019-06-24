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
        public conditionName name;
        public int turn;
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
