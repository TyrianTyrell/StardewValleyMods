using Magic.Framework.Spells;

namespace Magic.Framework.Schools
{
    internal class EldritchSchool : School
    {
        /*********
        ** Public methods
        *********/
        public EldritchSchool()
            : base(SchoolId.Eldritch) { }

        public override Spell[] SpellsTier1 = new[] { SpellManager.Get("eldritch:meteor"), SpellManager.Get("eldritch:bloodmana") };

        public override Spell[] SpellsTier2 = new[] { SpellManager.Get("eldritch:lucksteal") };

        public override Spell[] SpellsTier3 = new[] { SpellManager.Get("eldritch:spirit") };
    }
}
