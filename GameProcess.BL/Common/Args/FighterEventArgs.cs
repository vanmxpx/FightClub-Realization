using System;

namespace GameProcess.BL.Fighters
{
    public class FighterEventArgs : EventArgs
    {
        public int HP { get; private set; }
        public string Name { get; private set; }

        public FighterEventArgs(int hp, string name)
        {
            HP = hp;
            Name = name;
        }
    }
}

