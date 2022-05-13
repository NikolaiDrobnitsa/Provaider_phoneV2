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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 400, y = 80;
            Model1 model = new Model1();
            foreach (var item in model.Phone_info)
            {

                this.Controls.Add(new UserControl1(item.id, item.name, item.surname, item.phone_number) { Location = new Point(x, y) });

                y += 50;
                //if (x / 250 >= 5)
                //{
                //    y += 280;
                //    x = 400;
                //}

            }



        }
    }
}
