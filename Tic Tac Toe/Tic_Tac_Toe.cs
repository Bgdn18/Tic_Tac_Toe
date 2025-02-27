using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Tic_Tac_Toe
{
    public partial class Tic_Tac_Toe : Form
    {
        List<Button> buttons = new List<Button>();
        string tag;

        public Tic_Tac_Toe()
        {
            InitializeComponent();

            // Добавляем кнопки с формы в список
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);

            // Назначаем обработчики событий для кнопок
            foreach (var button in buttons)
            {
                button.Click += ButtonClick;
            }

            GenerateTag();

            lblCurrentPlayer.Text = $"Сейчас ходит: {tag}"; // Устанавливаем начальный текст для Label

            // Запрет изменения размера окна
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // Убираем кнопку максимизации 
        }

        private void MessageBox(Random rand)
        {
            // Создание и отображение CustomMessageBox
            var customMessageBox = new CustomMessageBox("You Win!", "Congratulations!", MessageBoxIcon.Information);
            customMessageBox.Show(); // Показываем форму
        }

        bool CheckWin(string player)
        {
            // Проверка горизонтальных линий
            for (int i = 0; i < 9; i += 3)
            {
                if (buttons[i].Text == player && buttons[i + 1].Text == player && buttons[i + 2].Text == player)
                {
                    return true;
                }
            }

            // Проверка вертикальных линий
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == player && buttons[i + 3].Text == player && buttons[i + 6].Text == player)
                {
                    return true;
                }
            }

            // Проверка диагоналей
            if (buttons[0].Text == player && buttons[4].Text == player && buttons[8].Text == player)
            {
                return true;
            }
            if (buttons[2].Text == player && buttons[4].Text == player && buttons[6].Text == player)
            {
                return true;
            }

            return false;
        }

        void GenerateTag()
        {
            var r = new Random();
            tag = r.Next(0, 2) != 1 ? "X" : "O";
        }

        private void ButtonClick(object? sender, EventArgs e)
        {
            Random rand = new Random();

            var currentButton = sender as Button;
            currentButton.Text = tag;
            currentButton.Click -= ButtonClick;

            if (CheckWin(tag)) // Проверяем победителя для текущего игрока
            {
                MessageBox(rand);
                foreach (Button item in buttons)
                {
                    item.Click -= ButtonClick; // Отключаем все кнопки после победы
                }
            }
            else
            {
                // Меняем игрока
                tag = tag == "X" ? "O" : "X";
                lblCurrentPlayer.Text = $"Player's Turn: {tag}"; // Обновляем текст Label
            }
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            string exePath = Application.ExecutablePath;
            Process.Start(exePath);
            Application.Exit();
        }
    }
}