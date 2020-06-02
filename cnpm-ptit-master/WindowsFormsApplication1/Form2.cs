using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public String m_connect = @"Data Source=CANHPROXX\SERVER3;Initial Catalog=CHUNGKHOAN;Integrated Security=True";
        SqlConnection con = null;
        public delegate void NewForm();// ten gi cung dc
        public event NewForm OnNewForm;
        public Form2()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            OnNewForm += Form1_OnNewForm;///
            //load data vao luoi
            LoadData();

        }
        private void Form1_OnNewForm()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)
            {
                NewForm ff = new NewForm(Form1_OnNewForm);
                i.BeginInvoke(ff, null);
                return;
            }
            LoadData();
        }

        void LoadData()
        {
            DataTable dt = new DataTable();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT  MACP, GIAMUA2,KLMUA2, GIAMUA1,KLMUA1,GIAKHOP,KLKHOP,GIABAN2,KLBAN2,GIABAN1,KLBAN1 FROM DBO.BANGGIATRUCTUYEN", con);
            cmd.Notification = null;

            SqlDependency dp = new SqlDependency(cmd);
            dp.OnChange += Dp_OnChange;///

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            dataGridView1.DataSource = dt;
        }

        private void Dp_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency dp = sender as SqlDependency;
            dp.OnChange -= Dp_OnChange;
            if (OnNewForm != null)
            {
                OnNewForm();
            }
        }
    }
}
