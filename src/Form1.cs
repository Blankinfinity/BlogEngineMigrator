using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace BlogEngineMigrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            // New FolderBrowserDialog instance
            FolderBrowserDialog fld = new FolderBrowserDialog();

            // Set initial selected folder
            fld.SelectedPath = tbFolder.Text;

            // Show the "Make new folder" button
            fld.ShowNewFolderButton = true;

            if (fld.ShowDialog() == DialogResult.OK)
            {
                // Select successful
                MessageBox.Show("The folder you selected is : " + fld.SelectedPath);
                tbFolder.Text = fld.SelectedPath;
            }
            else
            {
                // Selection canceled
                MessageBox.Show("Operation canceled.");
            }
        }

        private void btnPickSQL_Click(object sender, EventArgs e)
        {
            var database = SqlDialogSelector.GetDatabaseConnectionString(tbSQL.Text);
            tbSQL.Text = database;
        }
        private void btMigrate_Click(object sender, EventArgs e)
        {
            // Get ProviderName to convert to
            var destProviderName = cbTo.Text;

            //BlogProvider convertTo = BlogService.Providers[destProviderName];

            //// Categories
            //// Load up Categories
            //List<Category> cats = BlogService.Provider.FillCategories();
            //foreach (Category cat in cats)
            //{
            //    convertTo.InsertCategory(cat);
            //}

            //// Posts
            //List<Post> posts = BlogService.Provider.FillPosts();
            //foreach (Post post in posts)
            //{
            //    convertTo.InsertPost(post);
            //}

            //// Pages
            //List<Page> pages = BlogService.Provider.FillPages();
            //foreach (Page page in pages)
            //{
            //    convertTo.InsertPage(page);
            //}

            //// Update Settings
            //StringDictionary settings = BlogService.Provider.LoadSettings();
            //convertTo.SaveSettings(settings);

            //// Update Ping Services
            //StringCollection pingServices = BlogService.Provider.LoadPingServices();
            //convertTo.SavePingServices(pingServices);

            //// Update display
            //btMigrate.Enabled = false;
            //MessageBox.Show("Data Copy Complete.");
        }
    }        
    }
