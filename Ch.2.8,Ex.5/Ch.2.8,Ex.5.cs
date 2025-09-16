using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ch._2._8_Ex._5
{
    /// <summary>
    /// This form allows users to input two numbers and compares them, updating the comparison result dynamically.
    /// Additionally implemented: a comparison sign that updates dynamically.
    /// </summary>
    public class MainForm : Form
    {
        Label label;
        TextBox textBox1;
        TextBox textBox2;
        Label comparison;

        public MainForm()
        {
            Text = "Number Comparer";
            Size = new Size(500, 180);
            BackColor = Color.LightGray;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            label = new Label();
            label.Text = "Please enter numbers in both boxes to compare.";
            label.SetBounds(50, 20, 400, 70);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Arial", 18, FontStyle.Bold);
            Controls.Add(label);

            textBox1 = new TextBox();
            textBox1.SetBounds(label.Left, label.Bottom + 10, 150, 30);
            textBox1.TextChanged += TextChange;
            Controls.Add(textBox1);

            textBox2 = new TextBox();
            textBox2.Size = textBox1.Size;
            textBox2.Location = new Point(label.Right - textBox2.Width, textBox1.Top);
            textBox2.TextChanged += TextChange;
            Controls.Add(textBox2);

            comparison = new Label();
            comparison.Text = "=";
            comparison.Font = new Font("Arial", 16, FontStyle.Bold);
            comparison.AutoSize = true;
            comparison.Location = new Point(textBox1.Right + 40, textBox1.Top);
            Controls.Add(comparison);
        }

        private void TextChange(object obj, EventArgs ea)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label.Text = "Please enter numbers in both boxes to compare.";
                comparison.Text = "?";
                if (textBox1.Text == "" && textBox2.Text == "") comparison.Text = "=";
                return;
            }

            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                if (num1 > num2)
                {
                    comparison.Text = ">";
                    label.Text = $"{num1} is greater than {num2}.";
                }
                else if (num1 < num2)
                {
                    comparison.Text = "<";
                    label.Text = $"{num1} is less than {num2}.";
                }
                else
                {
                    comparison.Text = "=";
                    label.Text = $"{num1} is equal to {num2}.";
                }
            }
            catch (FormatException)
            {
                label.Text = "Invalid input. Please enter valid numbers.";
                comparison.Text = "?";
            }
        }
    }
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }
}
