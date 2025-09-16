using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ch._2._8_Ex._9
{
    /// <summary>
    /// This form allows users to input text, change its font, color, and size via a menu.
    /// Additionally implemented: a button to copy the text (plain) to the clipboard.
    /// </summary>
    public class MainForm : Form
    {
        Label text;
        TextBox input;

        public MainForm()
        {
            Text = "Stylize text Plus";
            Size = new Size(400, 250);
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            text = new Label();
            text.SetBounds(10, 10, 370, 150);
            text.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(text);

            input = new TextBox();
            input.SetBounds(10, 170, 300, 30);
            input.TextChanged += TextChange;
            Controls.Add(input);

            MainMenu mainMenu = new MainMenu();

            MenuItem fontMenu = new MenuItem("Font");
            MenuItem colorMenu = new MenuItem("Color");
            MenuItem sizeMenu = new MenuItem("Size");

            string[] fonts = { "Arial", "Times New Roman", "Courier New" };
            Color[] colors = { Color.Black, Color.Red, Color.Green, Color.Blue };
            int[] sizes = { 8, 10, 12, 14, 16, 18, 20, 24, 28, 32 };

            foreach (string font in fonts)
            {
                MenuItem item = new MenuItem(font);
                item.Click += (s, e) => text.Font = new Font(font, text.Font.Size);
                fontMenu.MenuItems.Add(item);
            }
            foreach (Color color in colors)
            {
                MenuItem item = new MenuItem(color.Name);
                item.Click += (s, e) => text.ForeColor = color;
                colorMenu.MenuItems.Add(item);
            }
            foreach (int size in sizes)
            {
                MenuItem item = new MenuItem(size.ToString());
                item.Click += (s, e) => text.Font = new Font(text.Font.FontFamily, size);
                sizeMenu.MenuItems.Add(item);
            }

            mainMenu.MenuItems.Add(fontMenu);
            mainMenu.MenuItems.Add(colorMenu);
            mainMenu.MenuItems.Add(sizeMenu);
            Menu = mainMenu;

            Button copyButton = new Button();
            copyButton.Text = "Copy";
            copyButton.SetBounds(320, 165, 60, 30);
            copyButton.Click += (s, e) => Clipboard.SetText(text.Text);
            Controls.Add(copyButton);
        }

        private void TextChange(object sender, EventArgs e)
        {
            text.Text = input.Text;
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
