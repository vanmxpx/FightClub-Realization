using GameProcess.BL.Args;
using GameProcess.BL.Common.Constants;
using GameProcess.BL.Fighters;
using System;
using System.Collections.Generic;

namespace GameProcess.BL
{
    public class Logic : IFighting
    {
        public BasePlayer Player1 { get; private set; }
        public BasePlayer Player2 { get; private set; }
        public int Round { get; private set; }

        public event EventHandler<MessageEventArgs> Message;

        // Конструктор принимает два базовых игрока и не важно, какая у них реализация,
        // для любых игроков раунды будут одинаковы - один бьет, один защищается, и на это никак не должно влиять, кто именно бьет
        public Logic(BasePlayer player1, BasePlayer player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public void StartGame()
        {
            Player1.RoundAction = RoundAction.Attack;
            Player2.RoundAction = RoundAction.Defend;

            // Игроки получают событые, что их ударили.
            // Такой способ максимально передает суть взаимодействия между игроками - они обращаются друг к другу
            Player1.Struck += Player2.GetHit;
            Player2.Struck += Player1.GetHit;

            // По смерти одного процесс "награждает" другого. Это тоже процесс игры,
            // если делать это во view, потеряется часть логики
            Player1.Death += Player2.Win;
            Player2.Death += Player1.Win;

            Round = 1;

            SendMessage("Game started.");
            SendMessage($"Round {Round}!!");
        }

        public void MakeStep(BodyParts partPlayer1, BodyParts partPlayer2)
        {
            

            bool Player1Attack = Round % 2 != 0;

            if (Player1Attack)
            {
                FighterAction(Player2, partPlayer2, RoundAction.Defend);
                FighterAction(Player1, partPlayer1, RoundAction.Attack);
            }
            else
            {
                FighterAction(Player1, partPlayer1, RoundAction.Defend);
                FighterAction(Player2, partPlayer2, RoundAction.Attack);
            }

            if (Player1.Dead || Player2.Dead) return;

            Round++;
            SendMessage($"Round {Round} started!");

        }

        // Данный метод дублирует определение дейсвтвия для игрока, сделан сугубо для примера абстракции 
        // с расчетом на возможность добавления других действий игроку
        private void FighterAction(BasePlayer player, BodyParts part, RoundAction action)
        {
            switch (action)
            {
                case RoundAction.Attack:
                    player.Hit(part);
                    break;
                case RoundAction.Defend:
                    player.Block(part);
                    break;
                default:
                    break;
            }
        }

        private void SendMessage(string message)
        {
            Message?.Invoke(this, new MessageEventArgs(message, Round));
        }
    }
}
