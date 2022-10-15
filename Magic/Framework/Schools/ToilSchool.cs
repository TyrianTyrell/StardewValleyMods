using Magic.Framework.Spells;

namespace Magic.Framework.Schools
{
    internal class ToilSchool : School
    {
        /*********
        ** Public methods
        *********/
        public ToilSchool()
            : base(SchoolId.Toil) { }

        public override Spell[] SpellsTier1 = new[] { SpellManager.Get("toil:cleardebris"), SpellManager.Get("toil:till") };

        public override Spell[] SpellsTier2 = new[] { SpellManager.Get("toil:water") };

        public override Spell[] SpellsTier3 = new[] { SpellManager.Get("toil:blink") };
    }
}
