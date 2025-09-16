using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ch._2._8_Ex._4
{
    /// <summary>
    /// This form allows the user to enter text and stylize it using checkboxes (bold, italic, underline, strikeout).
    /// Additionally implemented: stylization with underline and strikeout, copy button to copy stylized text to clipboard while preserving formatting.
    /// Copying shows a message only once.
    /// (only works with applications that support rich text formatting, e.g. Word, WordPad, Outlook)
    /// </summary>
    public class MainForm : Form
    {
        Label text;
        TextBox textBox;
        CheckBox bold;
        CheckBox italic;
        CheckBox underline;
        CheckBox strikeout;
        bool hasBeenShown = false;

        public MainForm()
        {
            Size = new Size(500, 330);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Text = "Stylize text";

            text = new Label();
            text.Size = new Size(480, 150);
            text.Location = new Point(5, 5);
            text.BorderStyle = BorderStyle.FixedSingle;
            text.Font = new Font("Arial", 18);
            Controls.Add(text);

            Label label = new Label();
            label.Text = "Enter text:";
            label.Size = new Size(80, 20);
            label.Location = new Point(5, 170);
            Controls.Add(label);

            textBox = new TextBox();
            textBox.Size = new Size(300, 100);
            textBox.Location = new Point(label.Right + 5, 170);
            textBox.TextChanged += TextEntered;
            Controls.Add(textBox);

            bold = new CheckBox();
            bold.Text = "Bold";
            bold.Size = new Size(100, 20);
            bold.Location = new Point(5, textBox.Bottom + 5);
            bold.CheckedChanged += StyleChange;
            Controls.Add(bold);

            italic = new CheckBox();
            italic.Text = "Italic";
            italic.Size = new Size(100, 20);
            italic.Location = new Point(5, bold.Bottom + 5);
            italic.CheckedChanged += StyleChange;
            Controls.Add(italic);

            underline = new CheckBox();
            underline.Text = "Underline";
            underline.Size = new Size(100, 20);
            underline.Location = new Point(5, italic.Bottom + 5);
            underline.CheckedChanged += StyleChange;
            Controls.Add(underline);

            strikeout = new CheckBox();
            strikeout.Text = "Strikeout";
            strikeout.Size = new Size(100, 20);
            strikeout.Location = new Point(5, underline.Bottom + 5);
            strikeout.CheckedChanged += StyleChange;
            Controls.Add(strikeout);

            Button copy = new Button();
            copy.Text = "Copy";
            copy.Size = new Size(90, 20);
            copy.Location = new Point(textBox.Right + 5, textBox.Top);
            copy.Click += (obj, ea) =>
            {
                using (RichTextBox rtb = new RichTextBox()) // preserve formatting by using RichTextBox
                {
                    rtb.Text = text.Text;
                    rtb.Font = text.Font;

                    DataObject data = new DataObject();
                    data.SetData(DataFormats.Rtf, rtb.Rtf);
                    data.SetData(DataFormats.Text, rtb.Text);

                    Clipboard.SetDataObject(data, true);

                    if (!hasBeenShown)
                    {
                        MessageBox.Show("Text copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hasBeenShown = true;
                    }
                }
            };
            Controls.Add(copy);
        }

        private void TextEntered(object obj, EventArgs ea)
        {
            text.Text = textBox.Text;
        }
        private void StyleChange(object checkBox, EventArgs e)
        {
            if (checkBox == bold && bold.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Bold); // add bold while keeping other styles
            else if(checkBox == bold && !bold.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Bold); // remove bold while keeping other styles

            if (checkBox == italic && italic.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Italic); // add italic while keeping other styles
            else if(checkBox == italic && !italic.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Italic); // remove italic while keeping other styles

            if (checkBox == underline && underline.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Underline); // add underline while keeping other styles
            else if (checkBox == underline && !underline.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Underline); // remove underline while keeping other styles

            if (checkBox == strikeout && strikeout.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Strikeout); // add strikeout while keeping other styles
            else if (checkBox == strikeout && !strikeout.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Strikeout); // remove strikeout while keeping other styles
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
