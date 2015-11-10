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
    public partial class TwoZeroFourEightScoreView : Form,View
    {
   
            Model model;
            public TwoZeroFourEightScoreView()
            {
                InitializeComponent();
                model = new TwoZeroFourEightModel();
                
        }

            public void Notify(Model m)
            {
               
                UpdateScore(((TwoZeroFourEightModel)m).Getscore());

            }
            //score table
            private void UpdateScore(int s_score)
            {
                //score.crscore(s_score);
               
               
                lblScore.Text = Convert.ToString(s_score);

            }


          
           
   

       

          
        }


    

    }



