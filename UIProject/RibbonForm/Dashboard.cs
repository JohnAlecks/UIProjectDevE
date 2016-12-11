using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Sql;

namespace UIProject.RibbonForm
{
    public partial class Dashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public Dashboard()
        {
            InitializeComponent();
            MsSqlConnectionParameters msSqlParams = new MsSqlConnectionParameters();
            msSqlParams.AuthorizationType = MsSqlAuthorizationType.Windows;
            msSqlParams.ServerName = "ALECKSJOHAN6632";
            msSqlParams.DatabaseName = "CriminalRecord";

            DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource("Data Source 1", msSqlParams);
            SelectQuery selectQuery = SelectQueryFluentBuilder
                .AddTable("AdministrativeLaw")
                .SelectColumns("Criminal", "Address", "Punish_Level")
                .Build("Query 1");
            sqlDataSource.Queries.Add(selectQuery);
            sqlDataSource.Fill();
            
            DashboardObjectDataSource dataSource = new DashboardObjectDataSource();
            
            dashboardViewer1.Dashboard.DataSources.Add(sqlDataSource);

            // Creates a chart dashboard item with the specified data source 
            // and adds it to the Items collection to display within the dashboard.
            ChartDashboardItem chart = CreateChart(dataSource);
            dashboardViewer1.Dashboard.Items.Add(chart);

            // Reloads data in the data sources.
            dashboardViewer1.ReloadData();

        }
     
        private ChartDashboardItem CreateChart(DashboardObjectDataSource dataSource)
        {

            ChartDashboardItem chart = new ChartDashboardItem();
            chart.DataSource = dataSource;
            chart.Arguments.Add(new Dimension("Crime", DateTimeGroupInterval.Year));
            chart.SeriesDimensions.Add(new Dimension("OrderDate"));
            chart.Panes.Add(new ChartPane());
            SimpleSeries salesAmountSeries = new SimpleSeries(SimpleSeriesType.Bar);
            salesAmountSeries.Value = new Measure("Extended Price");
            // Adds created series to the pane's Series collection to display within this pane.
            chart.Panes[0].Series.Add(salesAmountSeries);

            chart.Panes.Add(new ChartPane());
            SimpleSeries taxesAmountSeries = new SimpleSeries(SimpleSeriesType.StackedBar);
            taxesAmountSeries.Value = new Measure("Quantity");
            chart.Panes[1].Series.Add(taxesAmountSeries);

            return chart;
        }

        private void dashboardDesigner1_Load(object sender, EventArgs e)
        {

        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
