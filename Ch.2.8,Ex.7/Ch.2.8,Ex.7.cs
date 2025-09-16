using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ch._2._8_Ex._4
{
    /// <summary>
    /// This form is an improved version of the Stylize text application (Ch.2.8, Ex.4) that allows users to copy the stylized text to the clipboard
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
        ListBox fontList;
        ComboBox colorList;
        bool hasBeenShown = false;

        public MainForm()
        {
            Size = new Size(500, 370);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Text = "Stylize text Pro";

            text = new Label();
            text.Size = new Size(480, 150);
            text.Location = new Point(5, 5);
            text.BorderStyle = BorderStyle.FixedSingle;
            text.Font = new Font("Arial", 18);
            Controls.Add(text);

            Label label = new Label();
            label.Text = "Enter text:";
            label.Size = new Size(80, 20);
            label.Location = new Point(5, text.Bottom + 15);
            Controls.Add(label);

            Label label2 = new Label();
            label2.Text = "Stylize:";
            label2.Size = new Size(80, 20);
            label2.Location = new Point(ClientSize.Width / 2 - 15, label.Bottom + 5);
            Controls.Add(label2);

            Label label3 = new Label();
            label3.Text = "Style";
            label3.Size = new Size(40, 20);
            label3.Location = new Point(15, 215);
            Controls.Add(label3);

            Label label4 = new Label();
            label4.Text = "Font";
            label4.Size = new Size(40, 20);
            label4.Location = new Point(label3.Right + 170, 215);
            Controls.Add(label4);

            Label label5 = new Label();
            label5.Text = "Color";
            label5.Size = new Size(40, 20);
            label5.Location = new Point(label4.Right + 125, 215);
            Controls.Add(label5);

            textBox = new TextBox();
            textBox.Size = new Size(300, 100);
            textBox.Location = new Point(label.Right + 5, text.Bottom + 15);
            textBox.TextChanged += TextEntered;
            Controls.Add(textBox);

            bold = new CheckBox();
            bold.Text = "Bold";
            bold.Font = new Font(bold.Font, FontStyle.Bold);
            bold.Size = new Size(100, 20);
            bold.Location = new Point(10, textBox.Bottom + 45);
            bold.CheckedChanged += StyleChange;
            Controls.Add(bold);

            italic = new CheckBox();
            italic.Text = "Italic";
            italic.Font = new Font(italic.Font, FontStyle.Italic);
            italic.Size = new Size(100, 20);
            italic.Location = new Point(10, bold.Bottom + 5);
            italic.CheckedChanged += StyleChange;
            Controls.Add(italic);

            underline = new CheckBox();
            underline.Text = "Underline";
            underline.Font = new Font(underline.Font, FontStyle.Underline);
            underline.Size = new Size(100, 20);
            underline.Location = new Point(10, italic.Bottom + 5);
            underline.CheckedChanged += StyleChange;
            Controls.Add(underline);

            strikeout = new CheckBox();
            strikeout.Text = "Strikeout";
            strikeout.Font = new Font(strikeout.Font, FontStyle.Strikeout);
            strikeout.Size = new Size(100, 20);
            strikeout.Location = new Point(10, underline.Bottom + 5);
            strikeout.CheckedChanged += StyleChange;
            Controls.Add(strikeout);

            fontList = new ListBox();
            fontList.Size = new Size(150, 100);
            fontList.Location = new Point(strikeout.Right + 65, label3.Bottom);
            foreach (FontFamily font in FontFamily.Families) fontList.Items.Add(font.Name);
            fontList.SelectedItem = "Arial";
            fontList.SelectedIndexChanged += FontOrColorChange;
            Controls.Add(fontList);

            colorList = new ComboBox();
            colorList.Size = new Size(150, 20);
            colorList.DropDownStyle = ComboBoxStyle.DropDownList;
            colorList.Location = new Point(fontList.Right + 10, label3.Bottom);
            foreach (KnownColor color in Enum.GetValues(typeof(KnownColor))) colorList.Items.Add(color);
            colorList.SelectedItem = KnownColor.Black;
            colorList.SelectedIndexChanged += FontOrColorChange;
            Controls.Add(colorList);


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
                    rtb.ForeColor = text.ForeColor;

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
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Bold);
            else if (checkBox == bold && !bold.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Bold);

            if (checkBox == italic && italic.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Italic);
            else if (checkBox == italic && !italic.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Italic);

            if (checkBox == underline && underline.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Underline);
            else if (checkBox == underline && !underline.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Underline);

            if (checkBox == strikeout && strikeout.Checked)
                text.Font = new Font(text.Font, text.Font.Style | FontStyle.Strikeout);
            else if (checkBox == strikeout && !strikeout.Checked)
                text.Font = new Font(text.Font, text.Font.Style & ~FontStyle.Strikeout);
        }
        private void FontOrColorChange(object obj, EventArgs ea)
        {
            if (obj == fontList)
            {
                if (fontList.SelectedItem != null)
                    text.Font = new Font((string)fontList.SelectedItem, text.Font.Size, text.Font.Style);
            }
            else
            {
                if (colorList.SelectedItem != null)
                    text.ForeColor = Color.FromKnownColor((KnownColor)colorList.SelectedItem);
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
