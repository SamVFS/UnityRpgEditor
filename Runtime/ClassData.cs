using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRpgEditor
{

    [CreateAssetMenu(menuName = "RPG Editor / New Class")]
    public class ClassData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 100)]
        public Sprite Icon { get; private set; }

        [field: SerializeField]
        public SkillData[] Skills { get; private set; }

    }
}
