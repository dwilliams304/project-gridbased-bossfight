using System.Collections.Generic;
using UnityEngine;

namespace ContradictiveGames
{
    [CreateAssetMenu(fileName = "Dialogue", menuName = "Custom/Dialogue")]
    public class DialogueData : ScriptableObject
    {
        public List<Dialogue> BossDamaged = new List<Dialogue>();
        public List<Dialogue> PlayerDamaged = new List<Dialogue>();
        public List<Dialogue> BossIntroSpeech = new List<Dialogue>();
        public List<Dialogue> BossVictorySpeech = new List<Dialogue>();
        public List<Dialogue> PlayerVictorySpeech = new List<Dialogue>();
    }
}
