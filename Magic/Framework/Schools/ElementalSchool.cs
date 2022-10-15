using Magic.Framework.Spells;

namespace Magic.Framework.Schools
{
    internal class ElementalSchool : School
    {
        /*********
        ** Public methods
        *********/
        public ElementalSchool()
            : base(SchoolId.Elemental) { }

        public override Spell[] SpellsTier1 = new[] { SpellManager.Get("elemental:fireball"), SpellManager.Get("elemental:frostbolt") };

        public override Spell[] SpellsTier2 = new[] { SpellManager.Get("elemental:descend") };

        public override Spell[] SpellsTier3 = new[] { SpellManager.Get("elemental:teleport") }
    }
}
