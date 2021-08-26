using polimorphismVeYarısOyunu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polimorphismVeYarısOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmStart.Start();

        }
        Human human = new Human();
        Org org = new Org();
        Elf elf = new Elf();
        private void tmStart_Tick(object sender, EventArgs e)
        {
            lblHuman.Left += human.GetSpeed();
            lblElf.Left += elf.GetSpeed();
            lblOrg.Left += org.GetSpeed();

            if (lblHuman.Right >= lblFinish.Left)
            { 
                tmStart.Stop();
                MessageBox.Show("insan kazandı");
               
            }
            else if (lblElf.Right >= lblFinish.Left)
            { 
                tmStart.Stop();
                MessageBox.Show("Elf kazandı");
               
            }
            else if (lblOrg.Right >= lblFinish.Left)
            {
                tmStart.Stop();
                MessageBox.Show("Org kazandı");
               
            }

        }
    }
}
