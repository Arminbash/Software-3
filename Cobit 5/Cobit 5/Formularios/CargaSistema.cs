using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Cobit_5.Formularios
{
    public partial class CargaSistema : SplashScreen
    {
        public CargaSistema()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        public enum SplashScreenCommand{
        }
        private void CargaSistema_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            frnPrincipal principal = new frnPrincipal();
            principal.Show(this);
            Timer1.Enabled = false;
        }
    }
}