using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationerySales
{
    public class Account
    {
        public string Cust_Name { get; set; }
        public string Cust_ID { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }


        public Account(string cid, string nm, string addr, string sta,string date, string type)
        {
            Cust_Name = nm;
            Cust_ID = cid;
            Address = addr;
            State = sta;
            Date = date;
            Type = type;
        }

        public virtual void showDetails()
        {
            MessageBox.Show(String.Format("Acc No: {0}\nName: {1}\nStreet: {2}\nCity: {3}\nState: {4}\nDate Joined: {5}",
                Cust_ID, Cust_Name, Address, State, Date));
        }
    }
}
