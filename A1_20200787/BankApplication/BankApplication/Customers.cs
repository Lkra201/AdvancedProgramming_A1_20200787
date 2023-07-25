using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BankApplication
{
    /// <summary>
    /// Customer Class
    /// </summary>
    abstract class Customers
    {
        // account number
        // balance
        private int customerID;
        protected string name;
        protected string contact;

        List<Customers> cus = new List<Customers>();

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string CustomerID   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string Contact   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

    }
}
