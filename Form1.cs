using System;
using System.Windows.Forms;

namespace First_CS_WINFORM;

public partial class Form1 : Form
{
    private Button button1;
    public Label label1;
    public Form1()
    {
        Text = "我的 Windows 應用程式";
        Width = 400;
        Height = 300;

        button1 = new Button();
        button1.Text = "點擊我!";
        button1.Location = new System.Drawing.Point(150, 100);
        button1.Click += Button1_Click;

        label1 = new Label();
        label1.Location = new System.Drawing.Point(150, 50);
        label1.Text = "Test Label";

        Controls.Add(button1);
        Controls.Add(label1);
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        label1.Text = "Button Clicked!";
    }
}
