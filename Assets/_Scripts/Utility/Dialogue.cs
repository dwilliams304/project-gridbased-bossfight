using UnityEngine;

namespace ContradictiveGames
{
    public enum Difficulty {
        Any,
        Easy,
        Normal,
        Hard,
        Deadly,
        NoReturn
    }

    [System.Serializable]
    public class Dialogue {
        [Tooltip("Dialogue that gets spoken")] 
            public string Speech = "Default dialogue, please change me!";
        [Tooltip("Weighted chance that it gets spoken in case we want rare dialogue")] 
            public float Weight = 100f;
        [Tooltip("Difficulty setting that needs to be on for this to get spoken")] 
            public Difficulty Difficulty = Difficulty.Any;
    }
}