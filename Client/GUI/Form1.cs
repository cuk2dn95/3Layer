using Client.BLL;
using Client.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        StudentBLL studentBLL;
        public Form1()
        {
            InitializeComponent();
            studentBLL = new StudentBLL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = addStudentName.Text;
            var lopId = addStudentLopId.Text;

            Student student = new Student { Name = name, LopId = Int32.Parse(lopId) };
            if (studentBLL.addStudent(student))
            {
                updateView();
            }
            else
            {
                error("them sinh vien that bai");
            }

        }
        void updateView()
        {
            dataGridView1.DataSource = studentBLL.getAllStudent();
        }

        public void error(string error)
        {
            MessageBox.Show(error, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(deleteStudentId.Text);
            if (studentBLL.deleteStudent(id))
                updateView();
            else error("xoa sinh vien that bai");
        }
    }

    }
