using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Ch._2._8_Ex._10
{
    public class Calculator : Form
    {
        private Label numbersLabel;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button backspace;
        private Button floatingPoint;
        private Button equal;
        private Button clear;

        public Calculator()
        {
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.ClientSize = new Size(462, 397);
            this.Name = "Calculator";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.BackColor = Color.WhiteSmoke;
            this.ResumeLayout(false);
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.clear = new System.Windows.Forms.Button();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.floatingPoint = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 359);
            this.clear.Name = "Clear";
            this.clear.Size = new System.Drawing.Size(75, 49);
            this.clear.TabIndex = 0;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new EventHandler(Clear);
            // 
            // numbersLabel
            // 
            this.numbersLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbersLabel.Location = new System.Drawing.Point(12, 9);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(420, 94);
            this.numbersLabel.TabIndex = 0;
            this.numbersLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.numbersLabel.Font = new Font("Arial", 40);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(OnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(93, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(OnClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(174, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(OnClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DarkCyan;
            this.button4.Location = new System.Drawing.Point(12, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(OnClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.AliceBlue;
            this.button5.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.DarkCyan;
            this.button5.Location = new System.Drawing.Point(93, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(OnClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.AliceBlue;
            this.button6.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.DarkCyan;
            this.button6.Location = new System.Drawing.Point(174, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new EventHandler(OnClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.AliceBlue;
            this.button7.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.DarkCyan;
            this.button7.Location = new System.Drawing.Point(12, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new EventHandler(OnClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.AliceBlue;
            this.button8.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.DarkCyan;
            this.button8.Location = new System.Drawing.Point(93, 278);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 75);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new EventHandler(OnClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.AliceBlue;
            this.button9.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button9.ForeColor = System.Drawing.Color.DarkCyan;
            this.button9.Location = new System.Drawing.Point(174, 278);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 75);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new EventHandler(OnClick);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.AliceBlue;
            this.button0.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.button0.ForeColor = System.Drawing.Color.DarkCyan;
            this.button0.Location = new System.Drawing.Point(93, 359);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 75);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new EventHandler(OnClick);
            // 
            // button10
            // 
            this.plus.BackColor = System.Drawing.Color.AliceBlue;
            this.plus.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.plus.Location = new System.Drawing.Point(266, 170);
            this.plus.Name = "button10";
            this.plus.Size = new System.Drawing.Size(80, 62);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new EventHandler(OnClick);
            // 
            // button11
            // 
            this.minus.BackColor = System.Drawing.Color.AliceBlue;
            this.minus.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.minus.Location = new System.Drawing.Point(352, 170);
            this.minus.Name = "button11";
            this.minus.Size = new System.Drawing.Size(80, 62);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new EventHandler(OnClick);
            // 
            // button12
            // 
            this.multiply.BackColor = System.Drawing.Color.AliceBlue;
            this.multiply.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.multiply.Location = new System.Drawing.Point(266, 238);
            this.multiply.Name = "button12";
            this.multiply.Size = new System.Drawing.Size(80, 62);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new EventHandler(OnClick);
            // 
            // button13
            // 
            this.divide.BackColor = System.Drawing.Color.AliceBlue;
            this.divide.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.divide.Location = new System.Drawing.Point(352, 238);
            this.divide.Name = "button13";
            this.divide.Size = new System.Drawing.Size(80, 62);
            this.divide.TabIndex = 14;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new EventHandler(OnClick);
            // 
            // button14
            // 
            this.backspace.BackColor = System.Drawing.Color.AliceBlue;
            this.backspace.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.backspace.Location = new System.Drawing.Point(352, 116);
            this.backspace.Name = "button14";
            this.backspace.Size = new System.Drawing.Size(80, 38);
            this.backspace.TabIndex = 15;
            this.backspace.Text = "<=";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new EventHandler(Backspace);
            // 
            // button15
            // 
            this.floatingPoint.BackColor = System.Drawing.Color.AliceBlue;
            this.floatingPoint.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.floatingPoint.Location = new System.Drawing.Point(266, 116);
            this.floatingPoint.Name = "button15";
            this.floatingPoint.Size = new System.Drawing.Size(80, 38);
            this.floatingPoint.TabIndex = 16;
            this.floatingPoint.Text = ".";
            this.floatingPoint.UseVisualStyleBackColor = true;
            this.floatingPoint.Click += new EventHandler(OnClick);
            // 
            // button16
            // 
            this.equal.BackColor = System.Drawing.Color.LightBlue;
            this.equal.Font = new System.Drawing.Font("Arial", 35F, System.Drawing.FontStyle.Bold);
            this.equal.Location = new System.Drawing.Point(334, 345);
            this.equal.Name = "button16";
            this.equal.Size = new System.Drawing.Size(98, 88);
            this.equal.TabIndex = 17;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new EventHandler(Solve);
            // 
            // Calculator
            // 
            this.ClientSize = new System.Drawing.Size(442, 445);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.floatingPoint);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.clear);
            this.Name = "Calculator";
            this.ResumeLayout(false);

        }

        List<char> contents = new List<char>();

        private void OnClick(object sender, EventArgs ae)
        {
            if (sender is Button btn)
            {
                if (numbersLabel.Text == "Error" ||
                    new string(contents.ToArray()) == "Infinity" ||
                    new string(contents.ToArray()) == "NaN") Clear(sender, ae);

                if (contents.Count > 12) return;

                char symb = btn.Text[0];

                if (contents.Count == 0)
                {
                    if (".+-x/".Contains(symb)) return;
                    contents.Add(symb);
                    numbersLabel.Text += contents[contents.Count - 1];
                }
                else if ((symb == '.' && !".+-x/".Contains(contents[contents.Count - 1])) ||
                    (!char.IsDigit(symb) && symb != '.' && !".+-x/".Contains(contents[contents.Count - 1]))
                    || (char.IsDigit(symb)))
                {
                    contents.Add(symb); // only if valid
                    numbersLabel.Text += contents[contents.Count - 1];
                }
            }
        }
        private void Clear(object sender, EventArgs e)
        {
            contents.Clear();
            numbersLabel.Text = "";
        }
        private void Backspace(object sender, EventArgs e)
        {
            if (contents.Count > 0)
            {
                contents.RemoveAt(contents.Count - 1);
                numbersLabel.Text = new string(contents.ToArray());
            }
        }
        private void Solve(object sender, EventArgs e)
        {
            Dictionary<char, KeyValuePair<int, int>> pairs = new Dictionary<char, KeyValuePair<int, int>>();

            if (contents.Count == 0 ||
                !contents.Any(i => i == '+' || i == '-' || i == 'x' || i == '/') ||
                ("+-x/.".Contains(contents[contents.Count - 1]))) return;

            try
            {
                string expression = new string(contents.ToArray());

                expression = expression.Replace('x', '*');

                var result = new DataTable().Compute(expression, null);

                string resultStr = Convert.ToDouble(result).ToString();

                numbersLabel.Text = resultStr;
                contents = resultStr.ToCharArray().ToList();
            }
            catch
            {
                // Handle errors like division by zero
                numbersLabel.Text = "Error";
                contents.Clear();
            }
        }
    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Run(new Calculator());
        }
    }
}