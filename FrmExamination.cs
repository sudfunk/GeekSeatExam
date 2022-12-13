using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeekSeatExam.@class;
using GeekSeatExam.@libs;


namespace GeekSeatExam
{
    public partial class FrmExamination : Form
    {
       

        public ObservableCollection<Person> PersonCompare = new ObservableCollection<Person>();

        public int iCountCtl;
        public FrmExamination()
        {
            InitializeComponent();
            string sW = txtWYC.Text;
            if (sW == null  )
            {
                DeathClass.iWizardUnderControl = 0;
            }
            else
            {
                DeathClass.iWizardUnderControl = int.Parse(txtWYC.Text);
            }
            
        }

        private void BtnCheckKilled_Click(object sender, EventArgs e)
        {
            txtKilledByYear.Text = DeathClass.DeathOfYear(int.Parse(txtYear.Text)).ToString();
        }

     

        private void cmdCompare_Click(object sender, EventArgs e)
        {
            iCountCtl = int.Parse(txtCompPerson.Text);
            // int iHeightCount = 0;
            for (int iBtn = 0; iBtn < iCountCtl; iBtn++)
            {

                System.Windows.Forms.Label lblAgeOfDeath = new System.Windows.Forms.Label();
                lblAgeOfDeath.Name = "lblAgeOfDeath_" + iBtn;
                lblAgeOfDeath.Location = new Point(550, 40 * (iBtn) + 100);
                lblAgeOfDeath.Width = 150;
                lblAgeOfDeath.BackColor = System.Drawing.Color.Transparent;
                lblAgeOfDeath.TextAlign = ContentAlignment.MiddleRight;
                lblAgeOfDeath.AutoSize = false;
                lblAgeOfDeath.Text = "Age of Death:";
                lblAgeOfDeath.Tag = iBtn;
                this.Controls.Add(lblAgeOfDeath);

                System.Windows.Forms.Label lblYearOfDeath = new System.Windows.Forms.Label();
                lblYearOfDeath.Name = "lblAgeOfDeath_" + iBtn;
                lblYearOfDeath.Location = new Point(820, 40 * (iBtn ) + 100);
                lblYearOfDeath.Width = 150;
                lblYearOfDeath.BackColor = System.Drawing.Color.Transparent;
                lblYearOfDeath.TextAlign = ContentAlignment.MiddleRight;
                lblYearOfDeath.AutoSize = false;
                lblYearOfDeath.Text = "Year of Death:";
                lblYearOfDeath.Tag = iBtn;
                this.Controls.Add(lblYearOfDeath);



                System.Windows.Forms.TextBox txtAgeOfDeath = new TextBox();
                txtAgeOfDeath.Name = "txtAgeOfDeath_" + iBtn;
                txtAgeOfDeath.Location = new Point(700, 40 * (iBtn) + 100);
                txtAgeOfDeath.Tag = iBtn;
                
                this.Controls.Add(txtAgeOfDeath);


                System.Windows.Forms.TextBox txtYearOfDeath = new TextBox();
                txtYearOfDeath.Name = "txtYearOfDeath_" + iBtn;
                txtYearOfDeath.Tag = iBtn;
                txtYearOfDeath.Location = new Point(980, 40 * (iBtn) + 100);
                this.Controls.Add(txtYearOfDeath);






            }

            Button btnCAYDeath = new Button();
            btnCAYDeath.Location = new Point(1000, 40 * iCountCtl + 100);
            btnCAYDeath.Text = "Check";
            btnCAYDeath.Height = 35;
            btnCAYDeath.Click += new EventHandler(ButtonClickOneEvent);
            btnCAYDeath.Tag = iCountCtl;
            this.Controls.Add(btnCAYDeath);

            System.Windows.Forms.Label lblRateOfDeath = new System.Windows.Forms.Label();
            lblRateOfDeath.Name = "lblRateOfDeath" ;
            lblRateOfDeath.Location = new Point(550, 40 * iCountCtl + 100);
            lblRateOfDeath.Width = 150;
            lblRateOfDeath.BackColor = System.Drawing.Color.Transparent;
            lblRateOfDeath.TextAlign = ContentAlignment.MiddleRight;
            lblRateOfDeath.AutoSize = false;
            lblRateOfDeath.Text = "Rate of Death:";
            
            this.Controls.Add(lblRateOfDeath);

            System.Windows.Forms.TextBox txtRateOfDeath = new TextBox();
            txtRateOfDeath.Name = "txtRateOfDeath" ;
            txtRateOfDeath.Tag = "txtRate_"+iCountCtl.ToString();
            txtRateOfDeath.Location = new Point(700, 40 * iCountCtl + 100);
            this.Controls.Add(txtRateOfDeath);


        }

        void ButtonClickOneEvent(object sender, EventArgs e)
        {

            int[] iDeath=new int[iCountCtl];

            System.Windows.Forms.Button? btnCAYDeath = sender as Button;

            DeathClass.iWizardUnderControl = int.Parse(txtWYC.Text);

            DialogResult result = MessageBox.Show("Do You Want to continue", "Yes Or No", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
           
            {
                txtMessage.Text = "";
                for (int iDt = 0; iDt < iCountCtl; iDt++)
                {

                    Person orang = new Person(); 
                    string sKey1 = "txtAgeOfDeath_" + iDt.ToString();
                    string sKey2 = "txtYearOfDeath_" + iDt.ToString();
                    TextBox? txt1 = Controls.Find(sKey1, true).FirstOrDefault() as TextBox;
                    TextBox? txt2 = Controls.Find(sKey2, true).FirstOrDefault() as TextBox;
                    int iNilai1 = int.Parse(s: txt1.Text);
                    int iNilai2 = int.Parse(s: txt2.Text);

                    iDeath[iDt] = DeathClass.DeathOfYear(iNilai2-iNilai1);
                    PersonCompare.Add(new Person { Id = iDt, AgeOfDeath = iNilai1, YearOfDeath = iNilai2, CitizenDeathByYearOfDeath = iDeath[iDt] });
                    


                }
                
                TextBox? txtRate= Controls.Find("txtRateOfDeath", true).FirstOrDefault() as TextBox;
                txtRate.Text = "";
                int iDeathX = 0;
                
                // Read From Person  Class
                foreach (var iDtx in PersonCompare)
                {
                    iDeathX += iDtx.CitizenDeathByYearOfDeath;
                    txtMessage.Text += " Person " +iDtx.Id + " Total People That Killed in year :" +iDtx.YearOfDeath + " is/are: "  + iDtx.CitizenDeathByYearOfDeath   + "\n";

                }
                
                    txtRate.Text = ( float.Parse(iDeathX.ToString()) / float.Parse(iCountCtl.ToString())).ToString("N2");
                    txtMessage.Text += "Rate of People Death :" + txtRate.Text + "\n";

            }
      
        }
    }

}
