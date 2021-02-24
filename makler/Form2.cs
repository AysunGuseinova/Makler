using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace makler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public void goster(string w)
        {
            con.Open();
         OleDbDataAdapter  da = new OleDbDataAdapter(w, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }


        public
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Seymur\\Documents\\Database1011.mdb");
        OleDbCommand com;
        OleDbDataAdapter da;
        string tikinti, temir, unvan, rayon;

        int i, j, id, otaq, mertebe, sahe, nomre;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1011DataSet2.makler' table. You can move, or remove it, as needed.
            this.maklerTableAdapter1.Fill(this.database1011DataSet2.makler);
        
         

        }

        public int Nomre(string w)
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(w, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();

            int K = ds.Tables[0].Rows.Count;
            if (K > 0)
                return Convert.ToInt16(ds.Tables[0].Rows[K - 1].ItemArray[0].ToString());
            else return (0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
          int S=Nomre("Select* from sahib where ad like '"+textBox1.Text+"'");
          textBox2.Text = S.ToString();
          goster("select* from makler where nomre like '" + textBox2.Text + "'");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
          
    }
}
