using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Object
{
    public partial class FormStudent : Form
    {

        private Student oStudent = new Student();

        public FormStudent()
        {
            InitializeComponent();
            buttonExit.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Store data entered at textboxes in the Object oStudent

            oStudent.StudentId = Convert.ToInt32(textBoxStudentId.Text);
            oStudent.FirstName = textBoxFirstName.Text;
            oStudent.LastName = textBoxLastName.Text;
            oStudent.PhoneNumber = textBoxPhoneNumber.Text;
            oStudent.EmailAddress = textBoxEmail.Text;

            listBoxStudentId.Items.Add(oStudent.StudentId);
            listBoxFirstName.Items.Add(oStudent.FirstName);
            listBoxLastName.Items.Add(oStudent.LastName);
            listBoxPhoneNumber.Items.Add(oStudent.PhoneNumber);
            listBoxEmail.Items.Add(oStudent.EmailAddress);

            textBoxStudentId.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxStudentId.Focus();

            buttonExit.Enabled = true;           
        }
    }
}
