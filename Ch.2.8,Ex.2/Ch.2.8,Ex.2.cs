using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ch._2._8_Ex._2
{
    /// <summary>
    /// This form implements a simple counter with increment, decrement, and close buttons.
    /// Additionally implemented: When the form is resized, the controls are repositioned to maintain a centered layout.
    /// </summary>
    class MainForm : Form
    {
        Label label;
        Button incrementButton;
        Button decrementButton;
        Button closeButton;

        public MainForm()
        {
            Text = "Counter";
            Width = 350;
            Height = 230;
            StartPosition = FormStartPosition.CenterScreen;

            label = new Label();
            label.Text = "0";
            label.Location = new Point(105, 40);
            label.Font = new Font("Arial", 18, FontStyle.Bold);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.ForeColor = Color.Blue;
            Controls.Add(label);

            incrementButton = new Button();
            incrementButton.Text = "+";
            incrementButton.Location = new Point(60, 100);
            incrementButton.Click += (a, b) => IncrementCounter();
            Controls.Add(incrementButton);

            decrementButton = new Button();
            decrementButton.Text = "-";
            decrementButton.Location = new Point(180, 100);
            decrementButton.Click += (a, b) => DecrementCounter();
            Controls.Add(decrementButton);

            closeButton = new Button();
            closeButton.Text = "Close";
            closeButton.Location = new Point(120, 150);
            closeButton.Click += (a, b) => CloseApp();
            Controls.Add(closeButton);

            SetLocations(this, EventArgs.Empty);

            Resize += SetLocations;
        }

        private void SetLocations(object obj, EventArgs ea)
        {
            // Center label
            label.Left = (ClientSize.Width - label.Width) / 2;
            label.Top = (ClientSize.Height - label.Height) / 3;

            // Position increment button
            incrementButton.Left = (ClientSize.Width / 2) - 80;
            incrementButton.Top = ClientSize.Height - 100;

            // Position decrement button
            decrementButton.Left = (ClientSize.Width / 2) + 20;
            decrementButton.Top = ClientSize.Height - 100;

            // Center close button
            closeButton.Left = (ClientSize.Width - closeButton.Width) / 2;
            closeButton.Top = ClientSize.Height - 40 - closeButton.Height;
        }
        private void IncrementCounter()
        {
            label.Text = (int.Parse(label.Text) + 1).ToString();
        }
        private void DecrementCounter()
        {
            label.Text = (int.Parse(label.Text) - 1).ToString();
        }
        private void CloseApp()
        {
            Application.Exit();
        }
    }
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
