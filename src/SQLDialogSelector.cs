using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogEngineMigrator
{
    public class SqlDialogSelector
    {
        /// <summary>
        /// Gets VS.NET comes with a database connection dialog database connection information
        /// </Summary>
        /// <param name = "conn" > initialize the connection string </param>
        /// The<returns> database connection</returns>
        public static string GetDatabaseConnectionString(string conn)
        {
            var connString = string.Empty;
            var connDialog = new Microsoft.Data.ConnectionUI.DataConnectionDialog();

            // Add a data source list, you can add their own procedures required type of data source to the window must increase the following in any of eleven
            connDialog.DataSources.Add(Microsoft.Data.ConnectionUI.DataSource.AccessDataSource); // Access
            connDialog.DataSources.Add(Microsoft.Data.ConnectionUI.DataSource.OdbcDataSource); // ODBC
            connDialog.DataSources.Add(Microsoft.Data.ConnectionUI.DataSource.OracleDataSource); // Oracle
            connDialog.DataSources.Add(Microsoft.Data.ConnectionUI.DataSource.SqlDataSource); // Sql Server
            connDialog.DataSources.Add(Microsoft.Data.ConnectionUI.DataSource.SqlFileDataSource); // Sql Server File

            // Initialize
            connDialog.SelectedDataSource = Microsoft.Data.ConnectionUI.DataSource.SqlDataSource;
            connDialog.SelectedDataProvider = Microsoft.Data.ConnectionUI.DataProvider.SqlDataProvider;
            connDialog.ConnectionString = conn;
            // Can only through DataConnectionDialog class static method Show dialog box
            // Use Dialog.Show, (),, or dialog.ShowDialog() to render the dialog box
            if (Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(connDialog) == DialogResult.OK)
            {
                connString = connDialog.ConnectionString;
            }
            return connString;
        }
    }
}
