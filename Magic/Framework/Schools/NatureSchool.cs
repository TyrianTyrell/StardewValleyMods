using Magic.Framework.Spells;

namespace Magic.Framework.Schools
{
    internal class NatureSchool : School
    {
        /*********
        ** Public methods
        *********/
        public NatureSchool()
            : base(SchoolId.Nature) { }

        public override Spell[] SpellsTier1 = new[] { SpellManager.Get("nature:lantern"), SpellManager.Get("nature:tendrils") };

        public override Spell[] SpellsTier2 = new[] { SpellManager.Get("nature:shockwave") };

        public override Spell[] SpellsTier3 = new[] { SpellManager.Get("nature:photosynthesis") };
    }
}
