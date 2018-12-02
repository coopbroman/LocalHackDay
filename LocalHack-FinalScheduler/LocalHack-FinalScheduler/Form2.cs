using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalHack_FinalScheduler
{
    public partial class FRMinstruct : Form
    {
        public FRMinstruct()
        {
            InitializeComponent();
        }

        private void FRMinstruct_Load(object sender, EventArgs e)
        {

        }

        private void BTNstart_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                SchdlFRM mainFrm = new SchdlFRM();
                mainFrm.ShowDialog();
                this.Close();
               
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in the start button" + err.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
