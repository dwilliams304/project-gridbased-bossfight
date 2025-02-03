using UnityEngine;

[System.Flags]
public enum ThreatLevel
{
    Local = 1,
    Planetary = 2,
    LocalSystem = 3,
    Galactic = 4,
    MultiGalactic = 5,
    Universal = 6,
    Multiversal = 7
}

[System.Flags]
public enum BossClassification
{
    Humanoid = 1,
    Undead = 2,
    Beast = 3,
    Celestial = 4
}

namespace ContradictiveGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Boss Data", menuName = "Custom/BossData")]
    public class BossData : ScriptableObject
    {
        public Sprite BossImage;
        public string Name = "Default Name";
        public ThreatLevel ThreatLevel = ThreatLevel.Local;
        public BossClassification Classification = BossClassification.Humanoid;
        public string BossLore = "Default description";
    }
}