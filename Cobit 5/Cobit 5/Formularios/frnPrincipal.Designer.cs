namespace Cobit_5.Formularios
{
    partial class frnPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnPrincipal));
            this.frmPrincipal = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatosEmpresa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcesoEDM = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcesosAPO = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcesosBAI = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcesosDSS = new DevExpress.XtraBars.BarButtonItem();
            this.btnProcesosMEA = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelFrm = new System.Windows.Forms.Panel();
            this.spIdEmpresa = new DevExpress.XtraEditors.SpinEdit();
            this.btnCargarEmpresa = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.frmPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIdEmpresa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // frmPrincipal
            // 
            this.frmPrincipal.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.frmPrincipal.ExpandCollapseItem.Id = 0;
            this.frmPrincipal.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.frmPrincipal.ExpandCollapseItem,
            this.btnDatosEmpresa,
            this.barButtonItem1,
            this.btnGuardar,
            this.btnEditar,
            this.btnSalir,
            this.btnProcesoEDM,
            this.btnProcesosAPO,
            this.btnProcesosBAI,
            this.btnProcesosDSS,
            this.btnProcesosMEA,
            this.btnCargarEmpresa});
            this.frmPrincipal.Location = new System.Drawing.Point(0, 0);
            this.frmPrincipal.MaxItemId = 11;
            this.frmPrincipal.Name = "frmPrincipal";
            this.frmPrincipal.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.frmPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.frmPrincipal.Size = new System.Drawing.Size(442, 143);
            this.frmPrincipal.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.btnGuardar);
            this.applicationMenu1.ItemLinks.Add(this.btnEditar);
            this.applicationMenu1.ItemLinks.Add(this.btnCargarEmpresa);
            this.applicationMenu1.ItemLinks.Add(this.btnSalir);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.frmPrincipal;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Glyph")));
            this.btnGuardar.Id = 2;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditar.Glyph")));
            this.btnEditar.Id = 3;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSalir.Glyph")));
            this.btnSalir.Id = 4;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // btnDatosEmpresa
            // 
            this.btnDatosEmpresa.Caption = "Datos Empresa";
            this.btnDatosEmpresa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDatosEmpresa.Glyph")));
            this.btnDatosEmpresa.Id = 1;
            this.btnDatosEmpresa.Name = "btnDatosEmpresa";
            this.btnDatosEmpresa.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDatosEmpresa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatosEmpresa_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnProcesoEDM
            // 
            this.btnProcesoEDM.Caption = "Procesos EDM";
            this.btnProcesoEDM.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcesoEDM.Glyph")));
            this.btnProcesoEDM.Id = 5;
            this.btnProcesoEDM.Name = "btnProcesoEDM";
            this.btnProcesoEDM.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnProcesoEDM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcesoEDM_ItemClick);
            // 
            // btnProcesosAPO
            // 
            this.btnProcesosAPO.Caption = "Procesos APO";
            this.btnProcesosAPO.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcesosAPO.Glyph")));
            this.btnProcesosAPO.Id = 6;
            this.btnProcesosAPO.Name = "btnProcesosAPO";
            this.btnProcesosAPO.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnProcesosAPO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcesosAPO_ItemClick);
            // 
            // btnProcesosBAI
            // 
            this.btnProcesosBAI.Caption = "Procesos BAI";
            this.btnProcesosBAI.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcesosBAI.Glyph")));
            this.btnProcesosBAI.Id = 7;
            this.btnProcesosBAI.Name = "btnProcesosBAI";
            this.btnProcesosBAI.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnProcesosBAI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcesosBAI_ItemClick);
            // 
            // btnProcesosDSS
            // 
            this.btnProcesosDSS.Caption = "Procesos DSS";
            this.btnProcesosDSS.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcesosDSS.Glyph")));
            this.btnProcesosDSS.Id = 8;
            this.btnProcesosDSS.Name = "btnProcesosDSS";
            this.btnProcesosDSS.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnProcesosDSS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcesosDSS_ItemClick);
            // 
            // btnProcesosMEA
            // 
            this.btnProcesosMEA.Caption = "Procesos MEA";
            this.btnProcesosMEA.Glyph = ((System.Drawing.Image)(resources.GetObject("btnProcesosMEA.Glyph")));
            this.btnProcesosMEA.Id = 9;
            this.btnProcesosMEA.Name = "btnProcesosMEA";
            this.btnProcesosMEA.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnProcesosMEA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProcesosMEA_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Datos de la Empresa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDatosEmpresa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Procesos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProcesoEDM);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProcesosAPO);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProcesosBAI);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProcesosDSS);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnProcesosMEA);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Lista de Procesos";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.frmPrincipal;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            this.ribbonStatusBar.Click += new System.EventHandler(this.ribbonStatusBar_Click);
            // 
            // panelFrm
            // 
            this.panelFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrm.Location = new System.Drawing.Point(0, 143);
            this.panelFrm.Name = "panelFrm";
            this.panelFrm.Size = new System.Drawing.Size(442, 275);
            this.panelFrm.TabIndex = 2;
            // 
            // spIdEmpresa
            // 
            this.spIdEmpresa.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spIdEmpresa.Location = new System.Drawing.Point(330, 29);
            this.spIdEmpresa.MenuManager = this.frmPrincipal;
            this.spIdEmpresa.Name = "spIdEmpresa";
            this.spIdEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spIdEmpresa.Size = new System.Drawing.Size(100, 20);
            this.spIdEmpresa.TabIndex = 5;
            this.spIdEmpresa.Visible = false;
            // 
            // btnCargarEmpresa
            // 
            this.btnCargarEmpresa.Caption = "Cargar Empresa";
            this.btnCargarEmpresa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCargarEmpresa.Glyph")));
            this.btnCargarEmpresa.Id = 10;
            this.btnCargarEmpresa.Name = "btnCargarEmpresa";
            this.btnCargarEmpresa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCargarEmpresa_ItemClick);
            // 
            // frnPrincipal
            // 
            this.AllowMdiBar = true;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.spIdEmpresa);
            this.Controls.Add(this.panelFrm);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.frmPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "frnPrincipal";
            this.Ribbon = this.frmPrincipal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frnPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frnPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spIdEmpresa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl frmPrincipal;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDatosEmpresa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Panel panelFrm;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraEditors.SpinEdit spIdEmpresa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnProcesoEDM;
        private DevExpress.XtraBars.BarButtonItem btnProcesosAPO;
        private DevExpress.XtraBars.BarButtonItem btnProcesosBAI;
        private DevExpress.XtraBars.BarButtonItem btnProcesosDSS;
        private DevExpress.XtraBars.BarButtonItem btnProcesosMEA;
        private DevExpress.XtraBars.BarButtonItem btnCargarEmpresa;
    }
}