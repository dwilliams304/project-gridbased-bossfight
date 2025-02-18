using System.Collections.Generic;
using UnityEngine;

public enum ThreatLevel
{
    Local,
    Planetary,
    LocalSystem,
    Galactic,
    LocalCluster,
    Universal,
    Multiversal
}

public enum BossClassification
{
    Humanoid,
    Undead,
    Beast,
    Celestial,
    Entity,
    Demon,
    ArtificialIntelligence,
    Unknown
}

namespace ContradictiveGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Boss Data", menuName = "Custom/BossData")]
    public class BossData : ScriptableObject
    {
        [Header("Default Boss Information")]
        public Sprite BossImage;
        public string Name = "Default Name";
        public ThreatLevel ThreatLevel = ThreatLevel.Local;
        public BossClassification Classification = BossClassification.Humanoid;
        public string BossLore = "Default description";

        [Header("Fight Stats")]
        public int Health = 100;
        public float AttackSpeed = 1f;
        public int Damage = 1;
        public int MaxSpawnableTiles = 0; //0 = no max
        public int MaxSpecialTiles = 0; //0 = no max
        

        [Header("Tiles")]
        public List<Tile> Tiles = new List<Tile>();



        [Header("Dialogue Options")]
        public DialogueData DialogueData;

    }
}