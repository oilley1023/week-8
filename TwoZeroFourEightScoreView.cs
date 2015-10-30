using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form
    {
        
        public void cr_score(int num)
        {
            lblScore.Text = Convert.ToString(num);
        }
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
           
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
           // lblScore.Text = "Current score "+tmp_vaule;
          //  this.Hide();
          


        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }

        //public void Update()
        //{
        //    lblScore.Text = cr_score ;
        //}

        //public void crscore(int score)
        //{
        //    lblScore.Text = Convert.ToString(score);
        //}

    }

}
