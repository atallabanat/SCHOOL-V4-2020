using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCHOOL_DEV.UserControls
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();
        }

        private void btn_add_exp_year_Click(object sender, EventArgs e)
        {
            ADD_Users ssa = new ADD_Users();
           home.home2.addControlsTopanel(ssa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controls_user ssa = new controls_user();
            home.home2.addControlsTopanel(ssa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCDefultPaid ssa = new UCDefultPaid();
            home.home2.addControlsTopanel(ssa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UCRevenueName ssa = new UCRevenueName();
            home.home2.addControlsTopanel(ssa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCExpensesName ssa = new UCExpensesName();
            home.home2.addControlsTopanel(ssa);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Comf ssa = new Comf();
            home.home2.addControlsTopanel(ssa);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UP ssa = new UP();
            home.home2.addControlsTopanel(ssa);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewYear ssa = new NewYear();
            home.home2.addControlsTopanel(ssa);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            newSemester ssa = new newSemester();
            home.home2.addControlsTopanel(ssa);
        }
    }
}
