using GameProcess.BL.Common.Args;
using GameProcess.BL.Common.Constants;
using GameProcess.BL.Fighters;
using NUnit.Framework;

namespace GameProcess.BL.Test
{
    // Хорошим знаком того, что логика выделена будет написание для нее тестов
    // Они не все рабочие, не пугайтесь 
    [TestFixture]
    public class LogicTest
    {
        private Logic _logic;

        [SetUp]
        public void Init()
        {
            _logic = new Logic(new Player("Test"), new CPUPlayer());
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
            _logic.MakeStep(BodyParts.Body, BodyParts.Body);
            _logic.MakeStep(BodyParts.Body, BodyParts.Body);

            Assert.AreEqual(_logic.Round, round);
        }

        [Test]
        public void GenerateLogic_HPChanges()
        {
            int hp = 100;
            _logic.Player1.Hit(BodyParts.Leg);
            _logic.Player2.Hit(BodyParts.Leg);

            Assert.AreNotEqual(_logic.Player1.HealthPoints, hp);
            Assert.AreNotEqual(_logic.Player2.HealthPoints, hp);
        }

        [Test]
        public void GenerateLogic_HitBlocked()
        {
            int hp = 100;

            _logic.Player1.Block(BodyParts.Body);
            _logic.Player2.Block(BodyParts.Body);
            _logic.Player1.Hit(BodyParts.Body);
            _logic.Player2.Hit(BodyParts.Body);

            Assert.AreEqual(_logic.Player1.HealthPoints, hp);
            Assert.AreEqual(_logic.Player2.HealthPoints, hp);
        }

        [Test]
        public void GenerateLogic_PersonDead()
        {
            int hp = 0;
            for (int i = 0; i < 10; i++)
            {
                _logic.Player1.Hit(BodyParts.Body);
                _logic.Player2.Hit(BodyParts.Body);
            }

            Assert.AreEqual(_logic.Player1.HealthPoints, hp);
            Assert.AreEqual(_logic.Player2.HealthPoints, hp);
        }

        [Test]
        public void GenerateLogic_EventWound()
        {
            int _hp = 0;
            _logic.Player1.Wounded += (object sender, DamageEventArgs a) =>
            {
                _hp -= a.Damage;
            };

            _logic.Player1.Hit(BodyParts.Body);

            Assert.AreEqual(90, _hp);
        }

        [Test]
        public void GenerateLogic_EventBlock()
        {
            string _name = null;
            int _hp = 100;
            _logic.Player1.Blocked += (object sender, FighterEventArgs a) =>
            {
                _name = a.Name;
            };

            _logic.Player1.Block(BodyParts.Body);
            _logic.Player1.Hit(BodyParts.Body);

            Assert.AreEqual(_hp, _logic.Player1.HealthPoints);
            Assert.AreEqual(_logic.Player1.Name, _name);
        }

        [Test]
        public void GenerateLogic_EventDead()
        {
            string _name = null;
            int _hp = 0;
            _logic.Player1.Death += (object sender, FighterEventArgs a) =>
            {
                _name = a.Name;
            };

            _logic.Player1.Hit(BodyParts.Body);

            Assert.AreEqual(_hp, _logic.Player1.HealthPoints);
            Assert.AreEqual(_logic.Player1.Name, _name);
        }
    }
}
