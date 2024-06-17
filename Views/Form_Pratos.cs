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
    public partial class Form_Pratos : Form
    {
        public Form_Pratos()
        {
            InitializeComponent();

            cb_tipo.SelectedIndex = 1;
        }

    }
}
