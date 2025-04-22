using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRpgEditor
{
    [CreateAssetMenu(menuName = "RPG Editor / New Skill")]
    public class SkillData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 100)]
        public Sprite Icon { get; private set; }

        [field: SerializeField]
        public float CoolDown { get; private set; } = 5f;

        [field: SerializeField]
        public float CastDuration { get; private set; } = 0.75f;

        [field: SerializeField]
        public float AfterCastDelay { get; private set; } = 0.25f;

        [field: SerializeField]
        public int ManaCost { get; private set; } = 5;


    }
}
