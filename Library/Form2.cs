using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        Form1 form1 = new Form1();
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "admin" && textBox1.Text == "12345")
            {

                form1.Show();
                this.Hide();
                form1.lblllll.Text = textBox2.Text;


            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifreyi Kontrol Edin","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
}
