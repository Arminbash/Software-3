namespace Cobit_5.Formularios.Grids
{
    partial class frmListaEmpresas
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
            this.grdcEmpresas = new DevExpress.XtraGrid.GridControl();
            this.grdEmpresas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProposito = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdcEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdcEmpresas
            // 
            this.grdcEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcEmpresas.Location = new System.Drawing.Point(0, 0);
            this.grdcEmpresas.MainView = this.grdEmpresas;
            this.grdcEmpresas.Name = "grdcEmpresas";
            this.grdcEmpresas.Size = new System.Drawing.Size(614, 396);
            this.grdcEmpresas.TabIndex = 0;
            this.grdcEmpresas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdEmpresas});
            // 
            // grdEmpresas
            // 
            this.grdEmpresas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre,
            this.colProposito});
            this.grdEmpresas.GridControl = this.grdcEmpresas;
            this.grdEmpresas.Name = "grdEmpresas";
            this.grdEmpresas.OptionsBehavior.Editable = false;
            this.grdEmpresas.OptionsFind.AlwaysVisible = true;
            this.grdEmpresas.DoubleClick += new System.EventHandler(this.grdEmpresas_DoubleClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Nombre";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            // 
            // colProposito
            // 
            this.colProposito.Caption = "Proposito";
            this.colProposito.FieldName = "Proposito";
            this.colProposito.Name = "colProposito";
            this.colProposito.Visible = true;
            this.colProposito.VisibleIndex = 1;
            // 
            // frmListaEmpresas
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(614, 396);
            this.Controls.Add(this.grdcEmpresas);
            this.Name = "frmListaEmpresas";
            this.Text = "Lista Empresas";
            this.Load += new System.EventHandler(this.frmListaEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdcEmpresas;
        private DevExpress.XtraGrid.Views.Grid.GridView grdEmpresas;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colProposito;
    }
}