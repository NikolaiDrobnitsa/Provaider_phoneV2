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
            int x = 20, y = 10;
            Model1 model = new Model1();

            foreach (var item in model.Phone_info)
            {


                this.Controls.Add(new UserControl1(item.id, item.name, item.surname, item.phone_number) { Location = new Point(x, y) });
                //this.Controls.Add(new InfoControl(item.id, item.name, item.surname, item.phone_number, item.patronymic, item.date_of_birth) { Location = new Point(x, y) });

                y += 50;
                //if (x / 250 >= 5)
                //{
                //    y += 280;
                //    x = 400;
                //}

            }

        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            //UserControl1 user = new UserControl1();

            //user.add_people();
            int x = 20, y = 100;
            Model1 models = new Model1();
            //foreach (var item in models.Adres.Join(models.Cars, p => p.id, c => c.id, (p, c) => new {Name = p.contry, model = })
            foreach (var item in models.Adres)
            {

                this.Controls.Add(new InfoControl(item.id, item.apartment,item.city,item.contry,item.house,item.street) { Location = new Point(x, y) });

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
