using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roman_s_Time_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MilitaryButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MilitaryButton.Checked== true)
            {
                MilitaryEntry.Visible = true;
                MilitaryEntry2.Visible = true;
                Box1.Visible = true;
            }
            else
            {
                MilitaryEntry.Visible = false;
                MilitaryEntry2.Visible = false;
                Box1.Visible = false;
            }
        }

        private void RegularButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RegularButton.Checked == true)
            {
                RegularEntry.Visible = true;
                RegularEntry2.Visible = true;
                AMcheck.Visible = true;
                PMcheck.Visible = true;
                Box2.Visible = true;
            }
            else
            {
                RegularEntry.Visible = false;
                RegularEntry2.Visible = false;
                AMcheck.Visible = false;
                PMcheck.Visible = false;
                Box2.Visible = false;
            }

           
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            
            int Military = 0;
            int Military2 = 0;
            int Regular = 0;
            int Regular2 = 0;
            bool MilitaryBool;
            bool RegularBool;
            int Final1 = 0;
            int Final2 = 0;
            string AmPm = "";

            AmPmLabel.Enabled = false;
            AmPmLabel.Text = "";
            
            //fix reading of values
            //Processing 
            if (MilitaryButton.Checked == true)
            {
                MilitaryBool = int.TryParse(MilitaryEntry.Text, out Military);
                MilitaryBool = int.TryParse(MilitaryEntry2.Text, out Military2);

                if (MilitaryBool==false)
                {
                    MessageBox.Show("Enter a time");
                }
                if (Military >= 25 || Military < 1)
                {
                    MessageBox.Show("Military time has hours between 1 and 24 ");
                    return;
                }
                if (Military2 > 59 || Military2 < 0)
                {
                    MessageBox.Show("Minutes are between 0 and 59");
                    return;
                }
            }
            //will need some validation 
            if (MilitaryButton.Checked==true)
            {
                if (Military >= 13) 
                { Final1 = Military-12; }
                else { Final1 = Military; }

                Final2 = Military2;
                if(Final1>=1)
                
                FinalTime.Text = Final1.ToString() + ":"+ Final2.ToString();
                AmPmLabel.Enabled = true;
                if(Military>=1 && Military < 12 || Military==24)
                {
                    AmPm = "A.M";
                    AmPmLabel.Text = AmPm;
                }
                else
                {
                    AmPm = "P.M";
                    AmPmLabel.Text = AmPm;
                }
                //Leading 0 when entering 0
                if (Final2 == 0)
                {
                    FinalTime.Text = Final1.ToString() + ":" + Final2.ToString() + "0";

                }
               
                //Leading 0 with value less than 10
                if (Final2 < 10)
                {
                    FinalTime.Text = Final1.ToString() + ":" + "0"+Final2.ToString();

                }
            
            }
            if (RegularButton.Checked==true)
            {
                RegularBool = int.TryParse(RegularEntry.Text, out Regular);
                RegularBool = int.TryParse(RegularEntry2.Text, out Regular2);

                if(RegularBool==false)
                {
                    MessageBox.Show("Enter a Valid Time");
                    return;
                }

                if(Regular>=13 || Regular<=0)
                {
                    MessageBox.Show("Enter a Valid Time, invaid hour");
                    return;
                }
                if (Regular2 > 59 || Regular2 < 0)
                {
                    MessageBox.Show("Minutes are between 0 and 59");
                    return;
                }
                if (PMcheck.Checked == true)
                {
                    Final1 = Regular + 12;
                }
                else Final1 = Regular;
                Final2 = Regular2;
               
               
                //Leading 0 when entering 0
                if (Final2 == 0)
                {
                    FinalTime.Text = Final1.ToString() + ":" + Final2.ToString() + "0";

                }

                //Leading 0 with value less than 10
                if (Final2 < 10)
                {
                    FinalTime.Text = Final1.ToString() + ":" + "0" + Final2.ToString();

                }
                else
                {
                    FinalTime.Text = Final1.ToString() + ":"+ Final2.ToString();
                }
            }
        }
    
        private void Clear_Click(object sender, EventArgs e)
        {
            FinalTime.Text = "";
            AmPmLabel.Text = "";
            MilitaryButton.Checked = false;
            MilitaryEntry.Text = "";
            MilitaryEntry2.Text = "";
            RegularButton.Checked = false;
            RegularEntry.Text = "";
            RegularEntry2.Text = "";
            PMcheck.Checked=false;
            AMcheck.Checked=false;
        }
  
    }
}
