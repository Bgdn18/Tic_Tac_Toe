using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class CustomMessageBox : Form
    {
        // Конструктор формы
        public CustomMessageBox(string message, string caption, MessageBoxIcon icon)
        {
            InitializeComponent();

            // Устанавливаем заголовок и текст сообщения
            this.Text = caption;
            label1.Text = message;

            // Настройка иконки
            switch (icon)
            {
                case MessageBoxIcon.Information:
                    this.Icon = SystemIcons.Information; // Иконка информации
                    break;
                case MessageBoxIcon.Error:
                    this.Icon = SystemIcons.Error; // Иконка ошибки
                    break;
                case MessageBoxIcon.Question:
                    this.Icon = SystemIcons.Question; // Иконка вопроса
                    break;
                case MessageBoxIcon.Exclamation:
                    this.Icon = SystemIcons.Exclamation; // Иконка предупреждения
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // this.Close(); // Закрываем форму

            string exePath = Application.ExecutablePath;
            Process.Start(exePath);
            Application.Exit();
        }
    }
}