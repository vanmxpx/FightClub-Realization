using GameProcess.BL.Common.Constants;
using System;

namespace GameProcess.BL.Fighters
{
    public class Player: BasePlayer
    {
        public Player(string name) : base(name) { }

        public override void Block(BodyParts part)
        {
            SetBlock(part);
        }

        public override void Hit(BodyParts part)
        {
            MakeHit(part, ConstantFields.BasicDamage + _rnd.Next(-5, 6));
        }
    }
}
