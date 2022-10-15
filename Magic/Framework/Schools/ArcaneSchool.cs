using Magic.Framework.Spells;

namespace Magic.Framework.Schools
{
    internal class ArcaneSchool : School
    {
        /*********
        ** Public methods
        *********/
        public ArcaneSchool()
            : base(SchoolId.Arcane) { }

        public override Spell[] GetSpellsTier1() = new[] { SpellManager.Get("arcane:analyze"), SpellManager.Get("arcane:magicmissle") };

        public override Spell[] GetSpellsTier2() = new[] { SpellManager.Get("arcane:disenchant"), SpellManager.Get("arcane:enchant") };

        public override Spell[] SpellsTier3 = new[] { SpellManager.Get("arcane:rewind") };
    }
}
