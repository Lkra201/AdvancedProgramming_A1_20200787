using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
          


            
        }

        private void listBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Creating and setting the 
            // properties of ListBox
         /*   ListBox mylist = new ListBox();
            mylist.Location = new Point(287, 109);
            mylist.Size = new Size(120, 95);
            mylist.BorderStyle = BorderStyle.Fixed3D;
            mylist.Items.Add("Geeks");
            mylist.Items.Add("GFG");
            mylist.Items.Add("GeeksForGeeks");
            mylist.Items.Add("gfg");

            // Adding ListBox control to the form
            this.Controls.Add(mylist);
*/

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxCustomer.Items.AddRange(new string[] { "01", "Leone krauze", "1254897" });
            listBoxCustomer.Items.AddRange(new string[] { "02", "Alta Doodle", "1257897" });
            listBoxCustomer.Items.AddRange(new string[] { "03", "Izzy Made", "1897897" });
            listBoxCustomer.Items.AddRange(new string[] { "04", "Leo Self", "1212697" });
        }
    }
}
