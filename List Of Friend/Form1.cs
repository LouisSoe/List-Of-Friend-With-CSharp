using Faker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Of_Friend
{
    public partial class Form1 : Form
    {
        List<String> myFriend = new List<String>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource= myFriend;
            listBox1.DataSource = bs;
            txt_countFriend.Text = " 0 Friends";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text != "")
            {
                
                myFriend.Add(txt_name.Text);
                bs.ResetBindings(false);
                txt_name.Text = "";
                txt_countFriend.Text = myFriend.Count + "  Friends";
            }
        }

        private void btn_add5_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 5; i++)
            {
                string fakeName = Faker.Name.First();
                myFriend.Add(fakeName);
                bs.ResetBindings(false);
                txt_countFriend.Text = myFriend.Count + "  Friends";
            }
        }

        private void btn_atoz_Click(object sender, EventArgs e)
        {
            myFriend.Sort();
            bs.ResetBindings(false);
        }

        private void btn_ztoa_Click(object sender, EventArgs e)
        {
            myFriend.Sort();
            myFriend.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            myFriend.Clear();
            bs.ResetBindings(false);
            txt_countFriend.Text = myFriend.Count + "  Friends";
        }
    }
}
