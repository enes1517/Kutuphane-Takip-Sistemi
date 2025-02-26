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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal productDal = new ProductDal();
        ProductDalBook productDalBook = new ProductDalBook();   
        ProductDalMember ProductDalMember = new ProductDalMember();
        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            loadBook();
            loadMember();

        }

        private void load()
        {
            using (LibraryContext context = new LibraryContext())
            {
                dgwprotect.DataSource = productDal.GetAll();
            }
        }
        private void loadMember()
        {
            using (MemberContext context = new MemberContext())
            {
                dataGridView1.DataSource = ProductDalMember.GetAll();
            }
        }
        private void loadBook()
        {
            using (BookContext context = new BookContext())
            {
                {
                    dgwbook.DataSource = productDalBook.GetAll();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productDal.add(new product
            {

                MemberNumber= Convert.ToDecimal(tbxNameNumber.Text),
                Name = tbxName.Text,

                Surname = tbxSurname.Text,
                PhoneNumber = Convert.ToDecimal(tbxPhoneNumber.Text)

            });
            load();
            MessageBox.Show("Added");
            tbxNameNumber.Clear();
            tbxPhoneNumber.Clear();
            tbxName.Clear();
            tbxSurname.Clear();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            productDal.update(new product
            {
                Id = Convert.ToInt32(dgwprotect.CurrentRow.Cells[0].Value.ToString()),
                MemberNumber= Convert.ToDecimal(tbxNameNumber.Text),
                Name = tbxName.Text,
                Surname = tbxSurname.Text,
                PhoneNumber = Convert.ToDecimal(tbxPhoneNumber.Text)
            });
            load();
            MessageBox.Show("Updated");
            tbxNameNumber.Clear();
            tbxPhoneNumber.Clear();
            tbxName.Clear();
            tbxSurname.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            productDal.delete(new product
            {
                Id = Convert.ToInt32(dgwprotect.CurrentRow.Cells[0].Value.ToString()),

            });
            load();
            MessageBox.Show("Deleted");
        }

        private void dgwprotect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameNumber.Text = dgwprotect.CurrentRow.Cells[1].Value.ToString();
            tbxName.Text = dgwprotect.CurrentRow.Cells[2].Value.ToString();
            tbxSurname.Text = dgwprotect.CurrentRow.Cells[3].Value.ToString();
            tbxPhoneNumber.Text = dgwprotect.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productDalBook.add(new book
            {
                BookNumber= Convert.ToDecimal(tbxbooknumber.Text),
                Name= tbxad.Text,
                PublicationYear= Convert.ToDecimal(tbxPublicationYear.Text),
                ISBN= Convert.ToDecimal(tbxIsbn.Text),

            });
            loadBook();
            MessageBox.Show("Added");
           tbxbooknumber.Clear();
            tbxad.Clear();
            tbxPublicationYear.Clear();
            tbxIsbn.Clear();
        }

        private void dgwbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxbooknumber.Text = dgwbook.CurrentRow.Cells[1].Value.ToString();
            tbxad.Text = dgwbook.CurrentRow.Cells[2].Value.ToString();
            tbxPublicationYear.Text = dgwbook.CurrentRow.Cells[3].Value.ToString();
            tbxIsbn.Text = dgwbook.CurrentRow.Cells[4].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProductDalMember.delete(new member
            {
                Id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()),

            });
            DialogResult sonuc;
            sonuc = MessageBox.Show("Seçili satırı silmek istediğnize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                loadMember();
                MessageBox.Show("Silme işlemi başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxbookname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxnamesurname_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0;i<dgwprotect.Rows.Count;i++)
            {
                if (cbxnamesurname.Text == dgwprotect.Rows[i].Cells[2].Value.ToString()+" " + dgwprotect.Rows[i].Cells[3].Value.ToString())
                {
                    textBox2.Text = dgwprotect.Rows[i].Cells[1].Value.ToString();
                }
            }



        }

        private void cbxnamesurname_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }

        private void MemberAdd_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            cbxbookname.Items.Clear();
            cbxnamesurname.Items.Clear();
            for (int i = 0; i < dgwprotect.Rows.Count; i++)
            {
                cbxnamesurname.Items.Add(dgwprotect.Rows[i].Cells[2].Value.ToString() + " " + dgwprotect.Rows[i].Cells[3].Value.ToString());
            }
            for (int j = 0; j < dgwbook.Rows.Count; j++)
            {
                cbxbookname.Items.Add(dgwbook.Rows[j].Cells[2].Value.ToString());
            }

        }

        private void cbxbookname_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgwbook.Rows.Count; i++)
            {
                if (cbxbookname.Text == dgwbook.Rows[i].Cells[2].Value.ToString())
                {
                    textBox3.Text = dgwbook.Rows[i].Cells[1].Value.ToString();
                }
            }
        }

        private void dgwprotect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimeSpan kalanGun;
            kalanGun=dateTimePicker2.Value.Date-dateTimePicker1.Value.Date;
            ProductDalMember.add(new member
            {
                MemberNumber = Convert.ToInt32(textBox2.Text),
                BookNumber = Convert.ToInt32(textBox3.Text),
                StartDate = Convert.ToDateTime(dateTimePicker1.Value.ToLongDateString()),
                FinishDate = Convert.ToDateTime(dateTimePicker2.Value.ToLongDateString()),
                RemainingDay = kalanGun.Days,


            });
            loadMember();
            MessageBox.Show("Added");
            //dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToLongDateString(), dateTimePicker2.Value.ToLongDateString(),kalanGun.Days.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Uygulamayı kapatmak istediğnize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Hide();
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productDalBook.update(new book
            {
                Id=Convert.ToInt32( dgwbook.CurrentRow.Cells[0].Value.ToString()),
                BookNumber=Convert.ToDecimal(tbxbooknumber.Text),
                Name=tbxad.Text,
                PublicationYear=Convert.ToDecimal(tbxPublicationYear.Text),
                ISBN=Convert.ToDecimal(tbxIsbn.Text),

            });
            loadBook();
            MessageBox.Show("Updated");
            tbxbooknumber.Clear();
            tbxad.Clear();
            tbxPublicationYear.Clear();
            tbxIsbn.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            productDalBook.delete(new book
            {
                Id = Convert.ToInt32(dgwbook.CurrentRow.Cells[0].Value.ToString()),

            });
            DialogResult sonuc;
            sonuc = MessageBox.Show("Seçili satırı silmek istediğnize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                loadBook();
                MessageBox.Show("Silme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
