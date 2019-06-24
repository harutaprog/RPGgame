using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Character : MonoBehaviour
{
    public string name;

    public int HP;
    public int ATK;
    public int DEF;

    public UnityEvent[] Actions = new UnityEvent[6];
}
