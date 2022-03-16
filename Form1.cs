using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyExample
{
    public partial class Form1 : Form
    {
        private List<Exam> usersList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "localbdDataSet1.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.localbdDataSet1.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.dBDataSet.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.dBDataSet.user);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exam exam = new Exam();
            exam.Name = textBox1.Text;
            exam.Age = int.Parse(textBox2.Text);
            exam.Surname = textBox3.Text;
            exam.Middle_name = textBox4.Text;
            exam.Row = int.Parse(textBox5.Text);
            exam.Desk = int.Parse(textBox6.Text);
            exam.Discipline = textBox7.Text;

            LocalbdEntities _db = new LocalbdEntities();
            _db.Exam.Add(exam);
            _db.SaveChanges();

            //dataGridView1.Refresh();

            List<Exam> exampList = new List<Exam>();
            exampList = _db.Exam.ToList();
            dataGridView1.DataSource = exampList;





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
