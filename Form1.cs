using System;
using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp22
{
    public partial class Form1 : Form
    {
        private ProgressBar progressBar;
        private Label statusLabel;
        private Button startButton;
        public Form1()
        {
            Text = "Пример ProgressBar";
            Width = 400;
            Height = 200;

            statusLabel = new Label
            {
                Text = DateTime.Now.ToString(),
                Dock = DockStyle.Left,
                AutoSize = true
            };

            progressBar = new ProgressBar
            {
                Dock = DockStyle.Fill,
                Style = ProgressBarStyle.Continuous
            };

            startButton = new Button
            {
                Text = "Начать",
                Dock = DockStyle.Bottom
            };
            startButton.Click += StartButton_Click;

            Controls.Add(statusLabel);
            Controls.Add(progressBar);
            Controls.Add(startButton);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;
            statusLabel.Text = "Процесс выполняется...";

            for (int i = 0; i <= 100; i++)
            {
                progressBar.Value = i;
                Thread.Sleep(100);
            }

            statusLabel.Text = "Процесс завершен.";
        }
    }
    
}