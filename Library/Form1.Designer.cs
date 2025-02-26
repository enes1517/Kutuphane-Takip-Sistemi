namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgwprotect = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MemberAdd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxNameNumber = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPhoneNUmber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxbooknumber = new System.Windows.Forms.TextBox();
            this.tbxad = new System.Windows.Forms.TextBox();
            this.tbxIsbn = new System.Windows.Forms.TextBox();
            this.tbxPublicationYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwbook = new System.Windows.Forms.DataGridView();
            this.Memberİnformation = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxbookname = new System.Windows.Forms.ComboBox();
            this.cbxnamesurname = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblllll = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwprotect)).BeginInit();
            this.MemberAdd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbook)).BeginInit();
            this.Memberİnformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwprotect
            // 
            this.dgwprotect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwprotect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwprotect.Location = new System.Drawing.Point(37, 133);
            this.dgwprotect.Name = "dgwprotect";
            this.dgwprotect.RowHeadersWidth = 51;
            this.dgwprotect.RowTemplate.Height = 24;
            this.dgwprotect.Size = new System.Drawing.Size(985, 323);
            this.dgwprotect.TabIndex = 0;
            this.dgwprotect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwprotect_CellClick);
            this.dgwprotect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwprotect_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MemberAdd
            // 
            this.MemberAdd.Controls.Add(this.tabPage1);
            this.MemberAdd.Controls.Add(this.tabPage2);
            this.MemberAdd.Controls.Add(this.Memberİnformation);
            this.MemberAdd.Location = new System.Drawing.Point(12, 84);
            this.MemberAdd.Name = "MemberAdd";
            this.MemberAdd.SelectedIndex = 0;
            this.MemberAdd.Size = new System.Drawing.Size(1133, 510);
            this.MemberAdd.TabIndex = 2;
            this.MemberAdd.Enter += new System.EventHandler(this.MemberAdd_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxNameNumber);
            this.tabPage1.Controls.Add(this.tbxName);
            this.tabPage1.Controls.Add(this.tbxPhoneNumber);
            this.tabPage1.Controls.Add(this.tbxSurname);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.btnedit);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.lblSurname);
            this.tabPage1.Controls.Add(this.lblPhoneNUmber);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.lblId);
            this.tabPage1.Controls.Add(this.dgwprotect);
            this.tabPage1.ForeColor = System.Drawing.Color.Red;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1125, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Member Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbxNameNumber
            // 
            this.tbxNameNumber.Location = new System.Drawing.Point(136, 25);
            this.tbxNameNumber.Name = "tbxNameNumber";
            this.tbxNameNumber.Size = new System.Drawing.Size(100, 22);
            this.tbxNameNumber.TabIndex = 11;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(136, 87);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 22);
            this.tbxName.TabIndex = 10;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(368, 90);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.tbxPhoneNumber.TabIndex = 9;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(368, 31);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(100, 22);
            this.tbxSurname.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(493, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnedit.Location = new System.Drawing.Point(588, 44);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 50);
            this.btnedit.TabIndex = 6;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(669, 44);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 50);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(265, 31);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(64, 16);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblPhoneNUmber
            // 
            this.lblPhoneNUmber.AutoSize = true;
            this.lblPhoneNUmber.Location = new System.Drawing.Point(265, 93);
            this.lblPhoneNUmber.Name = "lblPhoneNUmber";
            this.lblPhoneNUmber.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNUmber.TabIndex = 3;
            this.lblPhoneNUmber.Text = "PhoneNumber:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(108, 16);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Member Number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxbooknumber);
            this.tabPage2.Controls.Add(this.tbxad);
            this.tabPage2.Controls.Add(this.tbxIsbn);
            this.tabPage2.Controls.Add(this.tbxPublicationYear);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgwbook);
            this.tabPage2.ForeColor = System.Drawing.Color.Red;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1125, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tbxbooknumber
            // 
            this.tbxbooknumber.Location = new System.Drawing.Point(153, 22);
            this.tbxbooknumber.Name = "tbxbooknumber";
            this.tbxbooknumber.Size = new System.Drawing.Size(100, 22);
            this.tbxbooknumber.TabIndex = 23;
            // 
            // tbxad
            // 
            this.tbxad.Location = new System.Drawing.Point(135, 93);
            this.tbxad.Name = "tbxad";
            this.tbxad.Size = new System.Drawing.Size(100, 22);
            this.tbxad.TabIndex = 22;
            // 
            // tbxIsbn
            // 
            this.tbxIsbn.Location = new System.Drawing.Point(411, 96);
            this.tbxIsbn.Name = "tbxIsbn";
            this.tbxIsbn.Size = new System.Drawing.Size(100, 22);
            this.tbxIsbn.TabIndex = 21;
            // 
            // tbxPublicationYear
            // 
            this.tbxPublicationYear.Location = new System.Drawing.Point(411, 31);
            this.tbxPublicationYear.Name = "tbxPublicationYear";
            this.tbxPublicationYear.Size = new System.Drawing.Size(100, 22);
            this.tbxPublicationYear.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(544, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(644, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 18;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(754, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 50);
            this.button3.TabIndex = 17;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Publication Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Book Number:";
            // 
            // dgwbook
            // 
            this.dgwbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwbook.Location = new System.Drawing.Point(69, 136);
            this.dgwbook.Name = "dgwbook";
            this.dgwbook.RowHeadersWidth = 51;
            this.dgwbook.RowTemplate.Height = 24;
            this.dgwbook.Size = new System.Drawing.Size(957, 309);
            this.dgwbook.TabIndex = 12;
            this.dgwbook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwbook_CellClick);
            // 
            // Memberİnformation
            // 
            this.Memberİnformation.BackColor = System.Drawing.Color.White;
            this.Memberİnformation.Controls.Add(this.dataGridView1);
            this.Memberİnformation.Controls.Add(this.label12);
            this.Memberİnformation.Controls.Add(this.label11);
            this.Memberİnformation.Controls.Add(this.dateTimePicker2);
            this.Memberİnformation.Controls.Add(this.dateTimePicker1);
            this.Memberİnformation.Controls.Add(this.cbxbookname);
            this.Memberİnformation.Controls.Add(this.cbxnamesurname);
            this.Memberİnformation.Controls.Add(this.textBox2);
            this.Memberİnformation.Controls.Add(this.textBox3);
            this.Memberİnformation.Controls.Add(this.button4);
            this.Memberİnformation.Controls.Add(this.button6);
            this.Memberİnformation.Controls.Add(this.label8);
            this.Memberİnformation.Controls.Add(this.label9);
            this.Memberİnformation.Controls.Add(this.label10);
            this.Memberİnformation.Controls.Add(this.lbl);
            this.Memberİnformation.ForeColor = System.Drawing.Color.Red;
            this.Memberİnformation.Location = new System.Drawing.Point(4, 25);
            this.Memberİnformation.Name = "Memberİnformation";
            this.Memberİnformation.Padding = new System.Windows.Forms.Padding(3);
            this.Memberİnformation.Size = new System.Drawing.Size(1125, 481);
            this.Memberİnformation.TabIndex = 2;
            this.Memberİnformation.Text = "Member İnformation";
            this.Memberİnformation.Click += new System.EventHandler(this.tabPage3_Click);
            this.Memberİnformation.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 276);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(676, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Start Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(676, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Finish Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(623, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(623, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // cbxbookname
            // 
            this.cbxbookname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbookname.FormattingEnabled = true;
            this.cbxbookname.Location = new System.Drawing.Point(483, 27);
            this.cbxbookname.Name = "cbxbookname";
            this.cbxbookname.Size = new System.Drawing.Size(121, 24);
            this.cbxbookname.TabIndex = 36;
            this.cbxbookname.SelectedIndexChanged += new System.EventHandler(this.cbxbookname_SelectedIndexChanged);
            this.cbxbookname.TextChanged += new System.EventHandler(this.cbxbookname_TextChanged);
            // 
            // cbxnamesurname
            // 
            this.cbxnamesurname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxnamesurname.FormattingEnabled = true;
            this.cbxnamesurname.Location = new System.Drawing.Point(220, 23);
            this.cbxnamesurname.Name = "cbxnamesurname";
            this.cbxnamesurname.Size = new System.Drawing.Size(121, 24);
            this.cbxnamesurname.TabIndex = 35;
            this.cbxnamesurname.SelectedIndexChanged += new System.EventHandler(this.cbxnamesurname_SelectedIndexChanged);
            this.cbxnamesurname.TextChanged += new System.EventHandler(this.cbxnamesurname_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(220, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(483, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(852, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 50);
            this.button4.TabIndex = 31;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(963, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 50);
            this.button6.TabIndex = 29;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(376, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Book Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(362, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Book Number:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Member Number:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(6, 27);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(197, 20);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Member Name-Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı";
            // 
            // lblllll
            // 
            this.lblllll.AutoSize = true;
            this.lblllll.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblllll.Location = new System.Drawing.Point(116, 24);
            this.lblllll.Name = "lblllll";
            this.lblllll.Size = new System.Drawing.Size(11, 16);
            this.lblllll.TabIndex = 4;
            this.lblllll.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(933, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(431, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kütüphane Takip Sistemi";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Aqua;
            this.button5.Location = new System.Drawing.Point(1011, 600);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 49);
            this.button5.TabIndex = 7;
            this.button5.Text = "Uygulamayı Kapat";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Aqua;
            this.button7.Location = new System.Drawing.Point(886, 600);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 49);
            this.button7.TabIndex = 8;
            this.button7.Text = "Oturumu Kapat";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1276, 723);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblllll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwprotect)).EndInit();
            this.MemberAdd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwbook)).EndInit();
            this.Memberİnformation.ResumeLayout(false);
            this.Memberİnformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwprotect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl MemberAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblPhoneNUmber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxNameNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblllll;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxbooknumber;
        private System.Windows.Forms.TextBox tbxad;
        private System.Windows.Forms.TextBox tbxIsbn;
        private System.Windows.Forms.TextBox tbxPublicationYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwbook;
        private System.Windows.Forms.TabPage Memberİnformation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbxbookname;
        private System.Windows.Forms.ComboBox cbxnamesurname;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}

