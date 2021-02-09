using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "newTestDataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.newTestDataSet.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "createNewTestDataSet.Exam". При необходимости она может быть перемещена или удалена.

            // TODO: данная строка кода позволяет загрузить данные в таблицу "createTestDataSet2.Exam". При необходимости она может быть перемещена или удалена.




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.q_title = textBox1.Text;
            q.q_opa = textBox2.Text;
            q.q_opb = textBox3.Text;
            q.q_opc = textBox4.Text;
            q.q_opcorrect = textBox5.Text;
            q.q_fk_ex = comboBox1.SelectedValue.ToString();
            InnerClass ic = new InnerClass();
             string msg=ic.insert_record(q);
            MessageBox.Show(msg);
        }
    }
}
