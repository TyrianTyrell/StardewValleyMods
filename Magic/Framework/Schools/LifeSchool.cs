using Magic.Framework.Spells;

namespace Magic.Framework.Schools
{
    internal class LifeSchool : School
    {
        /*********
        ** Public methods
        *********/
        public LifeSchool()
            : base(SchoolId.Life) { }

        public override Spell[] SpellsTier1 = new[] { SpellManager.Get("life:evac") };

        public override Spell[] SpellsTier2 = new[] { SpellManager.Get("life:heal"), SpellManager.Get("life:haste") };

        public override Spell[] SpellsTier3 = new[] { SpellManager.Get("life:buff") };
    }
}
