using UnityEngine;

namespace ContradictiveGames.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Level Data", menuName = "Custom/LevelData")]
    public class LevelData : ScriptableObject
    {
        public string sceneToLoad;

        public BossData bossData;
    }
}
