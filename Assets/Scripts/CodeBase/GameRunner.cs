using UnityEngine;

namespace Adventure.CodeBase
{
    public class GameRunner : MonoBehaviour
    {
        [SerializeField] private BootstrapperMain bootstrapperMainPrefab;

        private void Awake()
        {
            var bootstrapperMain = FindObjectOfType<BootstrapperMain>();

            if(bootstrapperMain == null)
                Instantiate(bootstrapperMainPrefab);
        }
    }
}