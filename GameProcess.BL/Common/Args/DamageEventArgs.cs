using GameProcess.BL.Common.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProcess.BL.Common.Args
{
    public class DamageEventArgs
    {
        public BodyParts BodyPart { get; private set; }
        public int Damage { get; private set; }

        public DamageEventArgs(BodyParts part, int damage)
        {
            BodyPart = part;
            Damage = damage;
        }
    }
}
