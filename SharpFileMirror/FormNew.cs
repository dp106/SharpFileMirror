using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpFileMirror
{
    public partial class FormNew : Form
    {
        private DataSet ds;
        public Boolean modifyRow = false;
        public int selectedRow = 0;
        public FormNew(DataSet _ds)
        {
            InitializeComponent();
            ds = _ds;            
        }

        private string getFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            string path = fbd.SelectedPath;
            Console.WriteLine(path);
            return path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = getFolder();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxDestination.Text = getFolder();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            if (modifyRow)
            {
                buttonAdd.Visible = false;
                buttonUpdate.Visible = true;
                DataRow dr = ds.Tables[0].Rows[selectedRow];
                object[] cellArray = dr.ItemArray;
                textBoxProfile.Text = cellArray[0].ToString();
                textBoxSource.Text = cellArray[1].ToString();
                textBoxDestination.Text = cellArray[2].ToString();
                textBoxFilter.Text = cellArray[3].ToString();
                comboBox1.Text = cellArray[4].ToString();
            }
            else {
                buttonAdd.Visible = true;
                buttonUpdate.Visible = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {            
            DataRow dr = ds.Tables[0].Rows.Add();
            dr.SetField("Profile", textBoxProfile.Text);
            dr.SetField("Source", textBoxSource.Text);
            dr.SetField("Destination", textBoxDestination.Text);
            dr.SetField("Filter", textBoxFilter.Text);
            dr.SetField("Direction", "Right");
            dr.SetField("Action", comboBox1.Text);
            ds.AcceptChanges();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {            
            DataRow dr = ds.Tables[0].Rows[selectedRow];
            dr.SetField("Profile", textBoxProfile.Text);
            dr.SetField("Source", textBoxSource.Text);
            dr.SetField("Destination", textBoxDestination.Text);
            dr.SetField("Filter", textBoxFilter.Text);
            dr.SetField("Direction", "Right");
            dr.SetField("Action", comboBox1.Text);
            ds.AcceptChanges();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
