using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_revenue_Click(object sender, EventArgs e)
        {
            int total = 0;
            int a_class, b_class, c_class = 0;

            try
            {
                a_class = (Convert.ToInt32(class_a_input.Text) * 15);
                class_a_label.Text = a_class.ToString() + " €";

                b_class = (Convert.ToInt32(class_b_input.Text) * 12);
                class_b_label.Text = b_class.ToString() + " €";

                c_class = (Convert.ToInt32(class_c_input.Text) * 9);
                class_c_label.Text = c_class.ToString() + " €";

                total += a_class + b_class + c_class;

                
                total_label.Text = total.ToString() + " €";
            }
            catch
            {
                MessageBox.Show("Input string was not in a correct format.");
            }
            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            class_a_input.Clear();
            class_b_input.Clear();
            class_c_input.Clear();

            class_a_label.Text = "";
            class_b_label.Text = "";
            class_c_label.Text = "";
            total_label.Text = "";
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
