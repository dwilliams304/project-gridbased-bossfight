using System.Collections.Generic;
using UnityEngine;

namespace ContradictiveGames
{
    [CreateAssetMenu(fileName = "Dialogue", menuName = "Custom/Dialogue")]
    public class DialogueData : ScriptableObject
    {
        public List<Dialogue> OnBossDamaged = new List<Dialogue>();
        public List<Dialogue> OnPlayerDamaged = new List<Dialogue>();
        public List<Dialogue> BossIntroSpeech = new List<Dialogue>();
        public List<Dialogue> OnBossVictorySpeech = new List<Dialogue>();
        public List<Dialogue> OnPlayerVictorySpeech = new List<Dialogue>();
    }
}
