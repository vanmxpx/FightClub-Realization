using GameProcess.BL.Fighters;
using NUnit.Framework;

namespace GameProcess.BL.Test
{
    [TestFixture]
    public class LogicTest
    {
        private Logic _logic;

        [SetUp]
        public void Init()
        {
            _logic = new Logic();
        }

        [Test]
        public void GenerateLogic_PlayersRequired()
        {
            Assert.That(_logic.Player1, Is.Not.Null);
            Assert.That(_logic.Player2, Is.Not.Null);
        }

        [Test]
        public void GenerateLogic_StepChanges()
        {
            int round = 3;
            _logic.MakeStep(BodyParts._body);
            _logic.MakeStep(BodyParts._body);

            Assert.AreEqual(_logic.Round, round);
        }

        [Test]
        public void GenerateLogic_HPChanges()
        {
            int hp = 50;
            _logic.Player1.GetHit(BodyParts._body, 50);
            _logic.Player2.GetHit(BodyParts._body, 50);

            Assert.AreEqual(_logic.Player1.HealthPoints, hp);
            Assert.AreEqual(_logic.Player2.HealthPoints, hp);
        }

        [Test]
        public void GenerateLogic_HitBlocked()
        {
            int hp = 100;

            _logic.Player1.SetBlock(BodyParts._body);
            _logic.Player2.SetBlock(BodyParts._body);
            _logic.Player1.GetHit(BodyParts._body, 50);
            _logic.Player2.GetHit(BodyParts._body, 50);

            Assert.AreEqual(_logic.Player1.HealthPoints, hp);
            Assert.AreEqual(_logic.Player2.HealthPoints, hp);
        }

        [Test]
        public void GenerateLogic_PersonDead()
        {
            int hp = 0;
            _logic.Player1.GetHit(BodyParts._body, 110);
            _logic.Player2.GetHit(BodyParts._body, 110);

            Assert.AreEqual(_logic.Player1.HealthPoints, hp);
            Assert.AreEqual(_logic.Player2.HealthPoints, hp);
        }

        [Test]
        public void GenerateLogic_EventWound()
        {
            string _name = null;
            int _hp = 0;
            _logic.Player1.Wound += (object sender, EventArgsFighter a) =>
            {
                _hp = a.HP;
                _name = a.Name;
            };

            _logic.Player1.GetHit(BodyParts._body, 10);

            Assert.AreEqual(90, _hp);
            Assert.AreEqual(_logic.Player1.Name, _name);
        }

        [Test]
        public void GenerateLogic_EventBlock()
        {
            string _name = null;
            int _hp = 100;
            _logic.Player1.Block += (object sender, EventArgsFighter a) =>
            {
                _name = a.Name;
            };

            _logic.Player1.SetBlock(BodyParts._body);
            _logic.Player1.GetHit(BodyParts._body, 10);

            Assert.AreEqual(_hp, _logic.Player1.HealthPoints);
            Assert.AreEqual(_logic.Player1.Name, _name);
        }

        [Test]
        public void GenerateLogic_EventDead()
        {
            string _name = null;
            int _hp = 0;
            _logic.Player1.Death += (object sender, EventArgsFighter a) =>
            {
                _name = a.Name;
            };

            _logic.Player1.GetHit(BodyParts._body, 110);

            Assert.AreEqual(_hp, _logic.Player1.HealthPoints);
            Assert.AreEqual(_logic.Player1.Name, _name);
        }
    }
}
