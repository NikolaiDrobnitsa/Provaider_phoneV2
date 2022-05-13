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
    public partial class UserControl1 : UserControl
    {
        public int id_collection;
        public UserControl1(int id, string name, string surname, string phone_number)
        {
            InitializeComponent();
            Name_label.Text = name;
            Surname_Label.Text = surname;
            Number_Label.Text = phone_number;
            id_collection = id;
        }

        private void More_button_Click(object sender, EventArgs e)
        {
            //Model1 model = new Model1();
            //model.Products.Remove(model.Products.Find(id_collection));
            //MessageBox.Show(model.Phone_info.Find());
            //model.SaveChanges();

            
        }

        public void add_people()
        {
            Model1 mode = new Model1();
            mode.Phone_info.Add(mode.Phone_info.Find(id_collection));
            
            mode.SaveChanges();
        } 
    }
}
