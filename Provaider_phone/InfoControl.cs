using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Provaider_phone
{
    public partial class InfoControl : UserControl
    {
        public InfoControl(int id, string name, string surname, string phone_number, string patronymic , string date_of_birth )
        {
            InitializeComponent();
            Names_label.Text = $"Name: {name}";
            Surname_label.Text = $"Surname: {surname}";
            patronymic_label.Text = $"Patronymic: {patronymic}";
            number_label.Text = $"Phone number: {phone_number}";
            Date_label.Text = $"Date of birth: {date_of_birth}";
        }

        private void InfoControl_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
