using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_qty.Text) * Convert.ToInt16(txtprice.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txtprice.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);


            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Green;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Black;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Sweets Item 1");
            cmb_items.Items.Add("Sweets Item 2");
            cmb_items.Items.Add("Sweets Item 3");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.Green;


            cmb_items.Items.Clear();
            cmb_items.Items.Add("Sweets Item 1");
            cmb_items.Items.Add("Sweets Item 2");
            cmb_items.Items.Add("Sweets Item 3");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Green;
            radioButton3.ForeColor = Color.Black;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Sweets Item 1");
            cmb_items.Items.Add("Sweets Item 2");
            cmb_items.Items.Add("Sweets Item 3");
        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "Sweets Item 1")
            { txtprice.Text = "50"; }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 2")
            { txtprice.Text = "100"; }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 3")
            { txtprice.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "Bakery Item 1")
            { txtprice.Text = "200"; }
            else if (cmb_items.SelectedItem.ToString() == "Bakery Item 2")
            { txtprice.Text = "250"; }
            else if (cmb_items.SelectedItem.ToString() == "Bakery Item 3")
            { txtprice.Text = "300"; }
            else
            { txtprice.Text = "0"; }


            txt_total.Text = "";
            txt_qty.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
