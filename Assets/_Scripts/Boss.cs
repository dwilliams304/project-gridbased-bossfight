using System.Collections.Generic;
using UnityEngine;

public enum ThreatLevel{
    Slight,
    Planetary,
    Local_System,
    Local_Group,
    Galactic,
    Multi_Galactic,
    Universal,
    Multiversal,
    Unclassified
}

[CreateAssetMenu(fileName = "Boss", menuName = "Boss")]
public class Boss : ScriptableObject
{
    [Header("Name, Threat Level")]
    public string BossName;
    public ThreatLevel threatLevel;

    [Header("Stats")]
    public int BossHealth;
    public int BossDamage;
    public float BossAtkSpeed;
    public int BossAtkTiles;

    [Header("Boss Speeches")]
    public List<string> BossIntro;
    public List<string> BossWin;
    public List<string> BossLose;
    public List<string> BossHurt;
    public List<string> PlayerHit;
    public List<string> BossSpecial;

    [Header("Specific Tiles")]
    public List<GameObject> SpecialTiles;
}
