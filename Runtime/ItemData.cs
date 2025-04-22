using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityRpgEditor
{
    public abstract class ItemData : ScriptableObject
    {
        [field: SerializeField]
        public string Name { get; private set; }

        [field: SerializeField]
        public string Description { get; private set; }

        [field: SerializeField, PreviewField(Height = 50)]
        public Sprite Icon { get; private set; }

        [field: SerializeField, SuffixLabel("Gold", true)]
        public int Value { get; private set; }
        
        [field: SerializeField, SuffixLabel("Kg", true)]
        public int Weight { get; private set; } 
        
        [field: SerializeField, SuffixLabel("Kg", true)]
        public ItemRarity Rarity{ get; private set; } = ItemRarity.Common;
    }

    public enum ItemRarity
    {
        Common, 
        Uncommon,
        Magic,
        Rare, 
        Epic, 
        Legendary,
        Mythic

    }
}
