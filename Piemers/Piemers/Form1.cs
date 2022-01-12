using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piemers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Paslept()
        {
            labLietotajs.Visible = false;
            labParole.Visible = false;
            txtLietotajs.Visible = false;
            txtParole.Visible = false;
            butPieslegties.Visible = false;
            labAtbilde.Visible = true;
        }
        private void butPieslegties_Click(object sender, EventArgs e)
        {
            Paslept();
            if (txtLietotajs.Text == "ilze")
            {
                if (txtParole.Text == "IlzesParole123")
                {
                    labAtbilde.Text = "Sveika, Ilze!";
                }
                else
                {
                    labAtbilde.Text = "Parole nav pareiza!";
                }
            }
            else if (txtLietotajs.Text == "admin")
            {
                if (txtParole.Text == "adminParole123")
                {
                    labAtbilde.Text = "Sveiks, Edgar!";
                }
                else
                {
                    labAtbilde.Text = "Parole nav pareiza!";
                }
            }
            else
            {
                labAtbilde.Text = "Tāds lietotājs neeksistē!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labAtbilde.Visible = false;
        }
    }
}
