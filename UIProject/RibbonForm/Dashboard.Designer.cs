namespace UIProject.RibbonForm
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery4 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column31 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression31 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table4 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column32 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression32 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column33 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression33 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column34 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression34 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column35 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression35 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column36 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression36 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column37 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression37 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column38 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression38 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column39 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression39 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column40 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression40 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.SuspendLayout();
            // 
            // dashboardDesigner1
            // 
            this.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner1.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.dashboardDesigner1.Name = "dashboardDesigner1";
            this.dashboardDesigner1.Size = new System.Drawing.Size(1236, 700);
            this.dashboardDesigner1.TabIndex = 0;
            this.dashboardDesigner1.Load += new System.EventHandler(this.dashboardDesigner1_Load);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "CriminalRecord.mdf";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression31.ColumnName = "Law_ID";
            table4.MetaSerializable = "30|30|125|240";
            table4.Name = "AdministrativeLaw";
            columnExpression31.Table = table4;
            column31.Expression = columnExpression31;
            columnExpression32.ColumnName = "User_ID";
            columnExpression32.Table = table4;
            column32.Expression = columnExpression32;
            columnExpression33.ColumnName = "Date_Punish";
            columnExpression33.Table = table4;
            column33.Expression = columnExpression33;
            columnExpression34.ColumnName = "Punish_Level";
            columnExpression34.Table = table4;
            column34.Expression = columnExpression34;
            columnExpression35.ColumnName = "Criminal";
            columnExpression35.Table = table4;
            column35.Expression = columnExpression35;
            columnExpression36.ColumnName = "Address";
            columnExpression36.Table = table4;
            column36.Expression = columnExpression36;
            columnExpression37.ColumnName = "DoB";
            columnExpression37.Table = table4;
            column37.Expression = columnExpression37;
            columnExpression38.ColumnName = "Citizen_veritification";
            columnExpression38.Table = table4;
            column38.Expression = columnExpression38;
            columnExpression39.ColumnName = "Information";
            columnExpression39.Table = table4;
            column39.Expression = columnExpression39;
            columnExpression40.ColumnName = "Result";
            columnExpression40.Table = table4;
            column40.Expression = columnExpression40;
            selectQuery4.Columns.Add(column31);
            selectQuery4.Columns.Add(column32);
            selectQuery4.Columns.Add(column33);
            selectQuery4.Columns.Add(column34);
            selectQuery4.Columns.Add(column35);
            selectQuery4.Columns.Add(column36);
            selectQuery4.Columns.Add(column37);
            selectQuery4.Columns.Add(column38);
            selectQuery4.Columns.Add(column39);
            selectQuery4.Columns.Add(column40);
            selectQuery4.Name = "AdministrativeLaw";
            selectQuery4.Tables.Add(table4);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery4});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dashboardDesigner1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1236, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}
