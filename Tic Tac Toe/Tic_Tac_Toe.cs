using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Tic_Tac_Toe : Form
    {
        List<Button> buttons = new List<Button>();
        string tag;
        public Tic_Tac_Toe()
        {
            InitializeComponent();
            Init();
   /* */        // Запрет изменения размера окна
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false; // Убираем кнопку максимизации 
        }

        bool CheckWin()
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (buttons[i].Text == buttons[i + 1].Text && buttons[i].Text == buttons[i + 2].Text && buttons[i].Text != "")
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == buttons[i + 3].Text && buttons[i].Text == buttons[i + 6].Text && buttons[i].Text != "")
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (buttons[0].Text == buttons[4].Text && buttons[i].Text == buttons[8].Text && buttons[4].Text != "")
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (buttons[2].Text == buttons[4].Text && buttons[i].Text == buttons[6].Text && buttons[4].Text != "")
                {
                    return true;
                }
            }
            return false;
        }

        void GenerateTag()
        {
            var r = new Random();
            tag = r.Next(0, 2) != 1 ? "X" : "O";
        }
        void ButtonsInit()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons.Add(new Button
                    {
                        Size = new Size(200, 200),
                        Location = new Point(i * 200, j * 200),
                        TabStop = false,
                        Font = new Font ("Arial", 70),
                    });
                    buttons[buttons.Count - 1].Click += ButtonClick;
                    Controls.Add(buttons[buttons.Count - 1]);
                }
            }
        }

        private void ButtonClick(object? sender, EventArgs e)
        {
            var currentButton = sender as Button;
            currentButton.Text = tag;
            currentButton.Click -= ButtonClick;
            if (CheckWin())
            {
                MessageBox.Show("won " + tag);
                foreach (Button item in buttons)
                {
                    item.Click -= ButtonClick;
                }
            }

             /* currentButton.Enabled = false;
             делает кнопку полупрозрачной (1 вариант)*/

             tag = tag == "X" ? "O" : "X";
        }

        void Init()
        {
           // ClientSize = new Size(600, 600);
            ButtonsInit();
            GenerateTag();
        }

    }

}