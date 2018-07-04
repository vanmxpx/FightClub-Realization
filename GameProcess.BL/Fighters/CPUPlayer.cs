using GameProcess.BL.Common.Constants;
using System;

namespace GameProcess.BL.Fighters
{
    public class CPUPlayer : BasePlayer
    {
        // Не даем кользователю создать имя, это самостоятельный объект
        public CPUPlayer()
            : base("CPU") {}

        public override void Hit(BodyParts part = BodyParts.Random)
        {
            // Компьютеру не прикажешь, запрещаем все, ктоме рандома
            if (part != BodyParts.Random)
                throw new Exception("Computer player can get only Random BodyPart.");
            MakeHit(GenerateBodyPart(), ConstantFields.BasicDamage + _rnd.Next(-5, 6));
        }

        public override void Block(BodyParts part = BodyParts.Random)
        {
            // Компьютеру не прикажешь, запрещаем все, ктоме рандома
            if (part != BodyParts.Random)
                throw new Exception("Computer player can get only  Random BodyPart.");
            SetBlock(GenerateBodyPart());
        }

        private BodyParts GenerateBodyPart()
        {
            return (BodyParts)_rnd.Next(1, 4);
        }

    }
}
