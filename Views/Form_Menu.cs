using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();

            List<object> items = new List<object>();
            items.Add(new { Text = "Almoço", Value = "12:00:00" });
            items.Add(new { Text = "Jantar", Value = "19:00:00" });

            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
        }
    }
}
