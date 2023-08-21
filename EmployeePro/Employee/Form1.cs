namespace Employee;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        b1.Click += Button1_click;
        
        
    }
    public int txt3int;
    public int isciSayan;
    private void Button1_click(object sender, EventArgs e){

        isciSayan += 1;
        txt3int = Convert.ToInt32(txt3.Text);
        
        if(txt1.Text.Length < 3){
            MessageBox.Show("ad 3 simvoldan kicik ola bilmez");
        }
        else if(txt2.Text.Length < 3){
            MessageBox.Show("soyad 3 simvoldan kicik ola bilmez");
        }
        else if(txt3int < 3 || txt3int < 18){
            MessageBox.Show("yas 18'den kicik, 65'den boyuk ola bilmez");
        }
        else{
            list1.Items.Add("isci " + isciSayan);
            list1.Items.Add(txt1.Text);
            list1.Items.Add(txt2.Text);
            list1.Items.Add(txt3.Text);
            list1.Items.Add(txt4.Text);
            list1.Items.Add(cmb1.Text);
            list1.Items.Add("--------------");
        }
        
        
        
    }
}
