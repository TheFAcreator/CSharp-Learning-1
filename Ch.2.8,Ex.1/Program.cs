using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// This form has a yellow background which changes to green when the mouse enters the form and reverts back to green when it leaves.
/// Upon clicking, the form increases its size by 10% and updates the title bar to reflect the new size.
/// </summary>
class MainForm : Form
{
    public MainForm()
    {
        this.Text = "Size: " + this.Width + " x " + this.Height;
        this.Size = new Size(300, 200);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.MaximizeBox = false;
        this.BackColor = Color.Yellow;
        this.Click += OnClick;
        this.MouseEnter += (a, b) => this.BackColor = Color.Green;
        this.MouseLeave += (a, b) => this.BackColor = Color.Yellow;
    }
    private void OnClick(object obj, EventArgs ae)
    {
        int h = (int)(this.Height * 0.1);
        int w = (int)(this.Width * 0.1);

        this.Left -= w / 2;
        this.Top -= h / 2;
        this.Height += h;
        this.Width += w;
        
        this.Text = String.Format("Size: {0} x {1}", this.Width, this.Height);
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