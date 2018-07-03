using FightingClub_Nikita.GameMenuItems;
using FightingClub_Nikita.Properties;
using GameProcess.BL;
using GameProcess.BL.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cоздаем все главные елементы в одном месте и соединяем их
            StartForm start = new StartForm();
            start.ShowDialog();

            // Управляющий класс для окна с логом, оно же будет 
            // выступать как основа приложения
            GameMenuController menu = new GameMenuController();
            Logic game = new Logic(new Player(Settings.Default.Name), new CPUPlayer());

            // Управляющий класс для всего приложения
            Presenter presenter = new Presenter(menu, game);

            Application.Run(menu.MenuForm);
        }
    }
}
