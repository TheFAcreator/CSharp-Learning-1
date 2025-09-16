using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace Ch._2._8_Ex._8
{
    /// <summary>
    /// This form contains a panel that changes its background color based on the user's selection from a context menu.
    /// </summary>
    public class MainForm : Form
    {
        Panel colorRenderer;

        public MainForm()
        {
            Size = new Size(400, 300);
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;

            colorRenderer = new Panel
            {
                Dock = DockStyle.Fill,
                //BackColor = Color.White
            };

            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.AddRange(new string[] { "Red", "Green", "Blue", "Gray", "Black", "Pink", "Purple" }
                .Select(color => new ToolStripMenuItem(color)).ToArray());
            contextMenu.ItemClicked += OnClick;
            colorRenderer.ContextMenuStrip = contextMenu;
            contextMenu.Items[0].PerformClick();

            Controls.Add(colorRenderer);
        }

        private void OnClick(object sender, ToolStripItemClickedEventArgs e)
        {
            string colorName = e.ClickedItem.Text;
            Color selectedColor = Color.FromName(colorName);
            colorRenderer.BackColor = selectedColor;
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
