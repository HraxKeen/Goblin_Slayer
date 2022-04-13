using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName =  "ScripttableObjects/Enemy", order = 1)]
public class EnemyData : ScriptableObject
{
    public int hp;
    public int damage;
    public float speed;
}
