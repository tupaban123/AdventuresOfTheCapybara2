using UnityEngine;

namespace Adventure.Player.Configs
{
    [CreateAssetMenu(fileName = "Player Config", menuName = "Configs/Player Config")]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
    }
}