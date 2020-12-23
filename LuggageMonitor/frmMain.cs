using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCWin;
using CCWin.SkinControl;
using CCWin.SkinClass;
using System.IO;

namespace LuggageMonitor
{
    public partial class frmMain :CCSkinMain
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void skinPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnFore_Click(object sender, EventArgs e)
        {
            try
            {
                FrmForceBootMonitor foreForm = new FrmForceBootMonitor();
                //foreForm.ShowDialog();
                if (foreForm.DialogResult != DialogResult.Cancel)
                {
                    this.Hide();
                    foreForm.ShowDialog();
                }
                foreForm.Dispose();
                foreForm = null;
                this.Show();
            }catch
            { 
            }
        }

        private void btnReal_Click(object sender, EventArgs e)
        {
            FrmRealBootMonitor realForm = new FrmRealBootMonitor();
            while (realForm.DialogResult != DialogResult.Cancel)
            {
                this.Hide();
                realForm.ShowDialog();
            }
            realForm.Dispose();
            realForm = null;
            this.Show();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            LuggageMonitor.TestPLC.SIEMENS from
                = new LuggageMonitor.TestPLC.SIEMENS();
            while (from.DialogResult != DialogResult.Cancel)
            {
                this.Hide();
                from.ShowDialog();
            }
            from.Dispose();
            from = null;
            this.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
              
                this.Close();
                this.Dispose();
                Application.Exit();
            }
            catch (Exception)
            {
 
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //HisSelect realForm = new HisSelect();
            //while (realForm.DialogResult != DialogResult.Cancel)
            //{
            //    this.Hide();
            //    realForm.ShowDialog();
            //}
            //realForm.Dispose();
            //realForm = null;
            //this.Show();
        }

   
    }
}
