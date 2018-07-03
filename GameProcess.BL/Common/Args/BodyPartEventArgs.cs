using GameProcess.BL.Common.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProcess.BL.Common.Args
{
    public class BodyPartEventArgs : EventArgs
    {
        public BodyParts Part { get; private set; }

        public BodyPartEventArgs(BodyParts part)
        {
            Part = part;
        }
    }
}
