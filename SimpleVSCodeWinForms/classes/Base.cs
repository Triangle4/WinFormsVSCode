using System;
using System.Windows.Forms;

public class Form1 : Form
{
    private MenuStrip menuStrip1 = new MenuStrip();
    private ToolStripMenuItem menu1 = new ToolStripMenuItem();
    private ToolStripMenuItem fileMenuItem = new ToolStripMenuItem();
    public void FormLayout()
    {
        Form();
        Menus();
    }
    
    void Form()
    {
        this.Name = "Form1";
        this.Text = "Form1";
        this.BackColor = System.Drawing.Color.Black;
        this.Size = new System.Drawing.Size(500, 500);
        this.FormBorderStyle = FormBorderStyle.None;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.KeyPreview = true;
    }  
    void Menus()
    {
        // menuStrip1
        this.menuStrip1.Items.AddRange(new ToolStripItem[] 
        {
            menu1
        });
        this.menuStrip1.BackColor = System.Drawing.Color.Black;
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Size = new System.Drawing.Size(800, 24);
        this.menuStrip1.Name = "menuStrip1";
        
        // Menu1
        this.menu1.Image = System.Drawing.Image.FromFile("images/menuHamburger.png");
        this.menu1.Size = new System.Drawing.Size(180, 20);
        this.menu1.Name = "menu1";   
        this.menu1.AutoSize = false;        
        this.menu1.DropDownItems.AddRange(new ToolStripItem[] 
        {
            this.fileMenuItem
        });

        this.fileMenuItem.Name = "fileMenuItem";
        this.fileMenuItem.AutoSize = false;
        this.fileMenuItem.Size = new System.Drawing.Size(180, 20);
        this.fileMenuItem.Text = "Exit";
        this.fileMenuItem.Click += new System.EventHandler(this.Mouse_Click);
        this.Controls.Add(this.menuStrip1);
    }

    void Mouse_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
    
           
}