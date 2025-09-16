using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ch._2._8_Ex._3
{
    /// <summary>
    /// This form contains a drop-down list of colors and a panel that displays the selected color.
    /// </summary>
    public class MainForm : Form
    {
        ComboBox colors;
        Panel colorRenderer;

        public MainForm()
        {
            Size = new Size(450, 300);
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;

            colorRenderer = new Panel
            {
                Size = new Size(ClientSize.Width - 200, ClientSize.Height - 10),
                Location = new Point(5, 5),
                BorderStyle = BorderStyle.FixedSingle
            };
            Controls.Add(colorRenderer);

            colors = new ComboBox
            {
                Width = ClientSize.Width - colorRenderer.Width - 15,
                Location = new Point(colorRenderer.Right + 5, 5),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            colors.Items.AddRange(new string[] { "Red", "Green", "Blue", "Yellow", "Cyan", "Magenta", "Black", "White" });
            colors.SelectedIndexChanged += SelectedIndexChanged;
            colors.SelectedIndex = 0;
            Controls.Add(colors);
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = colors.SelectedItem.ToString();
            Text = selectedColor;
            Color color = Color.FromName(selectedColor);
            colorRenderer.BackColor = color;
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
