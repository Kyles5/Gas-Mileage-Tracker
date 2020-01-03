using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasMileageTracker
{
    public partial class addVehicleForm : Form
    {
        public addVehicleForm()
        {
            InitializeComponent();
        }

        private void add(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
