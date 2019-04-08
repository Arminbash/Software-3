namespace Cobit_5.Formularios.Procesos
{
    partial class frmProcesosBAI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdcProcesos = new DevExpress.XtraGrid.GridControl();
            this.grdProcesos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colN5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdcProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Procesos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Construir, adquirir e implementar";
            // 
            // grdcProcesos
            // 
            this.grdcProcesos.Location = new System.Drawing.Point(17, 65);
            this.grdcProcesos.MainView = this.grdProcesos;
            this.grdcProcesos.Name = "grdcProcesos";
            this.grdcProcesos.Size = new System.Drawing.Size(793, 337);
            this.grdcProcesos.TabIndex = 9;
            this.grdcProcesos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdProcesos});
            // 
            // grdProcesos
            // 
            this.grdProcesos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProceso,
            this.colNombreProceso,
            this.colN0,
            this.colN1,
            this.colN2,
            this.colN3,
            this.colN4,
            this.colN5});
            this.grdProcesos.GridControl = this.grdcProcesos;
            this.grdProcesos.Name = "grdProcesos";
            this.grdProcesos.OptionsBehavior.AutoExpandAllGroups = true;
            this.grdProcesos.OptionsBehavior.Editable = false;
            this.grdProcesos.OptionsFind.AlwaysVisible = true;
            this.grdProcesos.DoubleClick += new System.EventHandler(this.grdProcesos_DoubleClick);
            // 
            // colidProceso
            // 
            this.colidProceso.Caption = "idProceso";
            this.colidProceso.FieldName = "idProceso";
            this.colidProceso.Name = "colidProceso";
            this.colidProceso.Visible = true;
            this.colidProceso.VisibleIndex = 0;
            // 
            // colNombreProceso
            // 
            this.colNombreProceso.Caption = "NombreProceso";
            this.colNombreProceso.FieldName = "NombreProceso";
            this.colNombreProceso.Name = "colNombreProceso";
            this.colNombreProceso.Visible = true;
            this.colNombreProceso.VisibleIndex = 1;
            // 
            // colN0
            // 
            this.colN0.Caption = "N0";
            this.colN0.FieldName = "N0";
            this.colN0.Name = "colN0";
            this.colN0.Visible = true;
            this.colN0.VisibleIndex = 2;
            // 
            // colN1
            // 
            this.colN1.Caption = "N1";
            this.colN1.FieldName = "N1";
            this.colN1.Name = "colN1";
            this.colN1.Visible = true;
            this.colN1.VisibleIndex = 3;
            // 
            // colN2
            // 
            this.colN2.Caption = "N2";
            this.colN2.FieldName = "N2";
            this.colN2.Name = "colN2";
            this.colN2.Visible = true;
            this.colN2.VisibleIndex = 4;
            // 
            // colN3
            // 
            this.colN3.Caption = "N3";
            this.colN3.FieldName = "N3";
            this.colN3.Name = "colN3";
            this.colN3.Visible = true;
            this.colN3.VisibleIndex = 5;
            // 
            // colN4
            // 
            this.colN4.Caption = "N4";
            this.colN4.FieldName = "N4";
            this.colN4.Name = "colN4";
            this.colN4.Visible = true;
            this.colN4.VisibleIndex = 6;
            // 
            // colN5
            // 
            this.colN5.Caption = "N5";
            this.colN5.FieldName = "N5";
            this.colN5.Name = "colN5";
            this.colN5.Visible = true;
            this.colN5.VisibleIndex = 7;
            // 
            // frmProcesosBAI
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(823, 521);
            this.Controls.Add(this.grdcProcesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProcesosBAI";
            this.Text = "frmProcesosBAI";
            this.Load += new System.EventHandler(this.frmProcesosBAI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProcesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl grdcProcesos;
        private DevExpress.XtraGrid.Views.Grid.GridView grdProcesos;
        private DevExpress.XtraGrid.Columns.GridColumn colidProceso;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreProceso;
        private DevExpress.XtraGrid.Columns.GridColumn colN0;
        private DevExpress.XtraGrid.Columns.GridColumn colN1;
        private DevExpress.XtraGrid.Columns.GridColumn colN2;
        private DevExpress.XtraGrid.Columns.GridColumn colN3;
        private DevExpress.XtraGrid.Columns.GridColumn colN4;
        private DevExpress.XtraGrid.Columns.GridColumn colN5;
    }
}