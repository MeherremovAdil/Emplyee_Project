namespace Employee;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 550);
        this.Text = "Form1";

        l1 = new Label();
        l1.Location = new Point(300,40);
        l1.Name = "label1";
        l1.Text = "Iscini elave edin";
        l1.Width = 400;
        this.Controls.Add(l1);
        
        l2 = new Label();
        l2.Location = new Point(150,90);
        l2.Name = "label2";
        l2.Text = "Iscinin adi: ";
        this.Controls.Add(l2);

        txt1 = new TextBox();
        txt1.Location = new Point(250,90);
        txt1.Name = "TextBox1";
        txt1.Width = 200;
        this.Controls.Add(txt1);

        l3 = new Label();
        l3.Location = new Point(150,120);
        l3.Name = "label3";
        l3.Text = "Iscinin soyadi: ";
        this.Controls.Add(l3);

        txt2 = new TextBox();
        txt2.Location = new Point(250,120);
        txt2.Name = "TextBox2";
        txt2.Width = 200;
        this.Controls.Add(txt2);

        l4 = new Label();
        l4.Location = new Point(150,150);
        l4.Name = "label4";
        l4.Text = "Iscinin yasi: ";
        this.Controls.Add(l4);

        txt3 = new TextBox();
        txt3.Location = new Point(250,150);
        txt3.Name = "TextBox3";
        txt3.Width = 200;
        this.Controls.Add(txt3);

        l5 = new Label();
        l5.Location = new Point(150,180);
        l5.Name = "label5";
        l5.Text = "Iscinin maasi: ";
        this.Controls.Add(l5);

        txt4 = new TextBox();
        txt4.Location = new Point(250,180);
        txt4.Name = "TextBox4";
        txt4.Width = 200;
        this.Controls.Add(txt4);

        l6 = new Label();
        l6.Location = new Point(150,210);
        l6.Name = "label6";
        l6.Text = "Iscinin vezifesi: ";
        this.Controls.Add(l6);

        cmb1 = new ComboBox();
        cmb1.Location = new Point(250,210);
        cmb1.Name = "ComboBox1";
        cmb1.Width = 200;
        cmb1.Items.Add("backend");
        cmb1.Items.Add("frontend");
        cmb1.Items.Add("database");
        this.Controls.Add(cmb1);

        b1 = new Button();
        b1.Location = new Point(250,250);
        b1.Name = "Button1";
        b1.Text = "Iscini elave et";
        b1.Width = 200;
        b1.Height = 50;
        b1.ForeColor = Color.White;
        b1.BackColor = Color.Green;
        this.Controls.Add(b1);

        list1 = new ListBox();
        list1.Location = new Point(150,330);
        list1.Name = "listBox1";
        list1.Width = 500;
        list1.Height = 200;
        this.Controls.Add(list1);

        p1 = new PictureBox();
        p1.Location = new Point(500,150);
        p1.Name = "pictureBox1";
        p1.ImageLocation = "";
        p1.Width = 130;
        p1.Height = 100;
        p1.SizeMode = PictureBoxSizeMode.StretchImage;
        this.Controls.Add(p1);
        
            
        


    }

    private Label l1;
    private Label l2;
    private Label l3;
    private Label l4;
    private Label l5;
    private Label l6;


    private TextBox txt1;
    private TextBox txt2;
    private TextBox txt3;
    private TextBox txt4;

    private ComboBox cmb1;
    private ListBox list1;

    private Button b1;


    private PictureBox p1;

    #endregion
}
