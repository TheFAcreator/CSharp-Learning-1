using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Ch._2._8_Ex._6
{
    /// <summary>
    /// This form displays images from a specified directory.
    /// The user can navigate through the images using "Next" and "Previous" buttons.
    /// Additionally implemented: The form's title updates to show the current image's filename.
    /// </summary>
    public class MainForm : Form
    {
        private const string PATH = @"C:\Users\bobip\Downloads\C_sharp_2\pictograms"; // There could be a message box asking for the path
        private string[] files = Directory.GetFiles(PATH, "*.jpg");
        private int index = 0;

        Label image;
        Button next;
        Button prev;


        public MainForm()
        {
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;

            image = new Label();
            image.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            image.Location = new Point(80, 20);
            image.Size = new Size(ClientSize.Width - 160, ClientSize.Height - 40);
            image.Image = Image.FromFile(files[index]);
            GetText();
            image.ImageAlign = ContentAlignment.MiddleCenter;
            image.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(image);

            next = new Button();
            next.Anchor = AnchorStyles.Right;
            next.Location = new Point(ClientSize.Width - next.Width, (ClientSize.Height - next.Height) / 2);
            next.Text = ">";
            next.Font = new Font("Arial", 24);
            next.Size = new Size(50, 50);
            next.Click += OnClick;
            Controls.Add(next);

            prev = new Button();
            prev.Anchor = AnchorStyles.Left;
            prev.Location = new Point(20, (ClientSize.Height - prev.Height) / 2);
            prev.Text = "<";
            prev.Font = new Font("Arial", 24);
            prev.Size = new Size(50, 50);
            prev.Click += OnClick;
            Controls.Add(prev);
        }
        
        private void OnClick(object obj, EventArgs ea)
        {
            if (obj == next)
            {
                Image img = Image.FromFile(files[++index % files.Length]);
                image.Image = img;
                GetText();
            }
            else if (obj == prev)
            {
                index = (index - 1 + files.Length) % files.Length;
                image.Image = Image.FromFile(files[index]);
                GetText();
            }
        }
        private void GetText()
        {
            string[] parts = files[index % files.Length].Split('\\');
            Text = parts[parts.Length - 1];
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
