using GameProcess.BL.Common.Args;
using GameProcess.BL.Common.Constants;
using System;

namespace GameProcess.BL.Fighters
{
    public abstract class BasePlayer
    {
        #region Variables
        public event EventHandler<DamageEventArgs> Struck;
        public event EventHandler<DamageEventArgs> Wounded;
        public event EventHandler<FighterEventArgs> Blocked;
        public event EventHandler<FighterEventArgs> Death;
        public event EventHandler<FighterEventArgs> Winner;

        protected Random _rnd = new Random();
        protected BodyParts _blocked;
        private int _hp;

        public RoundAction RoundAction { get; set; }
        public string Name { get; private set; }
        public bool Dead { get; private set; }
        public int HealthPoints
        {
            get { return _hp; }
            private set
            {
                _hp = value;
                if (_hp < 0)
                {
                    _hp = 0;
                    Dead = true;
                    Death?.Invoke(this,
                    new FighterEventArgs(HealthPoints, Name));
                }
            }
        }
        #endregion
        protected BasePlayer(String name, int hp)
        {
            Name = name;
            HealthPoints = hp;
        }

        protected BasePlayer(string name)
            : this(name, ConstantFields.BasicHp) { }

        public abstract void Hit(BodyParts part);
        public abstract void Block(BodyParts part);

        #region  Медоды взаимодействия игроков между собой
        public void GetHit(object sender, DamageEventArgs args)
        {
            if (args.BodyPart == _blocked)
            {
                Blocked?.Invoke(this,
                    new FighterEventArgs(HealthPoints, Name));
            }
            else
            {
                HealthPoints -= args.Damage;
                if (!Dead) Wounded?.Invoke(this, args);
            }
        }

        public void Win(object sender, FighterEventArgs e)
        {
            Winner?.Invoke(this, new FighterEventArgs(_hp, Name));
        }

        #endregion
        protected void MakeHit(BodyParts part, int damage)
        {
            Struck?.Invoke(this, new DamageEventArgs(part, damage));
            RoundAction = RoundAction.Defend;
        }
        protected void SetBlock(BodyParts _blocked)
        {
            this._blocked = _blocked;
            RoundAction = RoundAction.Attack;
        }

    }
}
