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
using Excell = Microsoft.Office.Interop.Excel;






namespace makler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Nomre(string w)
        {
            con.Open();
          OleDbDataAdapter da = new OleDbDataAdapter(w, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
          
           int K= ds.Tables[0].Rows.Count;
           if (K > 0)
               return Convert.ToInt16(ds.Tables[0].Rows[K - 1].ItemArray[0].ToString());
           else
               return(0);
        
        }



        public void goster(string w)
        { 
         con.Open();
         da = new OleDbDataAdapter(w, con);
         DataSet ds = new DataSet();
         da.Fill(ds);
         dataGridView1.DataSource = ds.Tables[0];
         con.Close();
        }



        public void goster1(string w)
        {
            con.Open();
            da = new OleDbDataAdapter(w, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }
     

        public

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Seymur\\Documents\\Database1011.mdb");         
        OleDbCommand com;
        OleDbDataAdapter da;
        string tikinti, temir, unvan, rayon,ad,vesiqe;
   
      int i,j,id,otaq,mertebe,sahe,nomre,qiymet,tel;
      int setir, sutun, setir1, sutun1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1011DataSet5.kiraye' table. You can move, or remove it, as needed.
            this.kirayeTableAdapter3.Fill(this.database1011DataSet5.kiraye);
         
            // TODO: This line of code loads data into the 'database1011DataSet1.makler' table. You can move, or remove it, as needed.
            this.maklerTableAdapter1.Fill(this.database1011DataSet1.makler);
       
     
          
     
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Gainsboro;

            goster("select* from Makler");

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string S = "";
            //int N = 0;
            //string Nom = DateTime.Now.Year.ToString();
            //Nom = Nom.Substring(2, 2);
            //N = Nomre("select* from makler"); N++;
            //if (N.ToString().Length == 1)
            //    S = Nom + "00" + N.ToString();
            //if (N.ToString().Length == 2)
            //    S = Nom + "0" + N.ToString();
            //if (N.ToString().Length == 3) S = Nom + N.ToString();
          //  int S = Nomre("select* from makler");
        

        
    
   
 


      if (button1.Text == "Save")
      {
          con.Open();
  
    //    da = new OleDbDataAdapter("select* from sahib where nomre like '" + S + "'", con);
          com = new OleDbCommand("Insert into Makler(nomre,tikinti_novu,temir,mertebe,otaq,rayon,sahe,unvan,qiymet,id) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox19.Text + "','"+textBox13.Text+"')", con);
          com.ExecuteNonQuery();
          con.Close();
      }
            
            goster("Select* from Makler");

       
      

        
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void dinamikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void rayonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goster("select* from Makler where rayon like '" + comboBox7.Text + "'");
            
        }

        private void nomreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goster("select* from Makler where nomre like '" + comboBox7.Text + "'");
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Visible = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox4.Visible = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox5.Visible = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox8.Visible = checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox9.Visible = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            comboBox6.Visible = checkBox6.Checked;
                
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            textBox10.Visible = checkBox7.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            textBox11.Visible = checkBox8.Checked;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            textBox12.Visible = checkBox9.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
                  string f = "where ", f1 = "", f2 = "", f3 = "", f4 = "", f5 = "", f6 = "",f7="",f8="",f9="";
            if (checkBox1.Checked)
                f1 = " Nomre like '" + textBox7.Text + "'";
            if (checkBox2.Checked)
                f2 = " tikinti_novu like '" + comboBox4.Text + "'";
            if (checkBox3.Checked)
                f3 = " temir like '" + comboBox5.Text + "'";
            if (checkBox4.Checked)
                f4 = " mertebe like '" + textBox8.Text + "'";
            if (checkBox5.Checked)
                f5 = " otaq like '" + textBox9.Text + "'";
            if (checkBox6.Checked)
                f6 = " rayon like '" + comboBox6.Text + "'";
            if (checkBox6.Checked)
                f7 = " sahe like '" + textBox10.Text + "'";
            if (checkBox6.Checked)
                f8 = " unvan  like '" + textBox11.Text + "'";
            if (checkBox6.Checked)
                f9= " id like '" + textBox12.Text + "'";


            if (f1 != "") { if (f == "where ") f = f + f1; else f = f + " and " + f1; }
            if (f2 != "") { if (f == "where ") f = f + f2; else f = f + " and " + f2; }
            if (f3 != "") { if (f == "where ") f = f + f3; else f = f + " and " + f3; }
            if (f4 != "") { if (f == "where ") f = f + f4; else f = f + " and " + f4; }
            if (f5 != "") { if (f == "where ") f = f + f5; else f = f + " and " + f5; }
            if (f6 != "") { if (f == "where ") f = f + f6; else f = f + " and " + f6; }
            if (f7 != "") { if (f == "where ") f = f + f7; else f = f + " and " + f7; }
            if (f8 != "") { if (f == "where ") f = f + f8; else f = f + " and " + f8; }
            if (f9 != "") { if (f == "where ") f = f + f9; else f = f + " and " + f9; }
           // MessageBox.Show(f);
            if (f == "where ")  goster("Select* from Makler ");
            else goster("Select* from Makler " +f);
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            goster("Select* from Makler");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new OleDbCommand("delete from Makler where Nomre like '" + textBox14.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
       
            DialogResult a = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            switch (a)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: break;
            }

            textBox14.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new OleDbCommand("delete from Makler",con);
            com.ExecuteNonQuery();
            con.Close();

            DialogResult a = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            switch (a)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: break;

            }
        }

        private void capEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
          

            Excell.Application xlapp;
            Excell.Workbook xb;
            Excell.Worksheet xs;
            object misValue = System.Reflection.Missing.Value;
            xlapp = new Excell.Application();
            xb = xlapp.Workbooks.Add(misValue);
            xs = (Excell.Worksheet)xb.Worksheets.get_Item(1);
            
            con.Open();
            da = new OleDbDataAdapter("select* from makler", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (j = 0; j < ds.Tables[0].Columns.Count ; j++)
                   xs.Cells[i + 1, j + 1] = ds.Tables[0].Rows[i].ItemArray[j].ToString();

            }
            xb.SaveAs(Application.StartupPath+"\\Csharp.xls", Excell.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excell.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue);
            xb.Close(true, misValue, misValue);
            xlapp.Quit();

        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        
        
        Excell._Application xlapp = new Excell.Application();
                xlapp.Workbooks.Open(Application.StartupPath+"\\Csharp.xls");
                Excell.Worksheet ws = xlapp.ActiveWorkbook.ActiveSheet;
                string S="";

int Col= ws.UsedRange.Columns.Count;
int Row=ws.UsedRange.Rows.Count;
MessageBox.Show("Row="+Row.ToString()+"  Col="+Col.ToString());
                for (int i = 0; i < Row; i++) 
                {
                    for (int j = 0; j < Col; j++)
                    {
                        
                         Excell.Range range = ws.Cells[i + 1, j + 1];
                    if(j<8)
                        S+=range.Value+"','";
                    else S+=range.Value;
                    }
                    MessageBox.Show(S);
                con.Open();
                com = new OleDbCommand("Insert into Makler(nomre,tikinti_novu,temir,mertebe,otaq,rayon,sahe,unvan,id) values('" + S+ "')", con);
                com.ExecuteNonQuery();
                con.Close();
                S="";        
                        
                    }
                
                xlapp.Quit();
            
            
        }

        private void yaddaSaxlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
        

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sahibeGoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox1.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
           int S = Nomre("select* from makler");
          S++;
         textBox15.Text = S.ToString();
         textBox1.Text = S.ToString();
         textBox20.Text = S.ToString();
          
            con.Open();
            com = new OleDbCommand("insert into sahib(nomre,ad,vesiqe,unvan,tel) values('" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + maskedTextBox1.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
       
          groupBox1.Visible = true;
          groupBox6.Visible = true;
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            id = 1; textBox13.Text = id.ToString();
            groupBox6.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            id = 0; textBox13.Text = id.ToString(); textBox21.Text = id.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
        
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
          


        }

        private void button15_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            groupBox7.Visible = checkBox10.Checked;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new OleDbCommand("Insert into kiraye(nomre,tarix1,tarix2,id)values('" + textBox20.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox21.Text + "')", con);
            com.ExecuteNonQuery();

            con.Close();
            goster1("select* from kiraye");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox8.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox8.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
           con.Open();
            com = new OleDbCommand("delete from Makler where nomre like  '"+dataGridView1[sutun,setir].Value.ToString()+"'", con);
            com.ExecuteNonQuery();
            con.Close();
        

            DialogResult a = MessageBox.Show("Are you sure?", " ", MessageBoxButtons.YesNo);
            switch (a)
            {
                case DialogResult.Yes: break;
                case DialogResult.No: break;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox9.Visible = true;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            groupBox9.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
           con.Open();
           com = new OleDbCommand("update  kiraye set tarix1='" + dateTimePicker3.Value.ToShortDateString() + "'where nomre like '" + dataGridView2[sutun1, setir1].Value.ToString() + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            con.Open();
            com = new OleDbCommand("update  kiraye set tarix2='" + dateTimePicker4.Value.ToShortDateString() + "'where nomre like '" + dataGridView2[sutun1, setir1].Value.ToString() + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            if (radioButton3.Checked)
                goster1("select* from kiraye where id like '2'");
            if (radioButton4.Checked)
                goster1("select* from kiraye where id like '0'");

            goster1("select* from kiraye");
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            groupBox8.Visible = true;
            setir = e.RowIndex;
            sutun = e.ColumnIndex;

        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
        


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            id = 1; textBox21.Text = id.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            id = 0; textBox21.Text = id.ToString();

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            textBox24.Visible = checkBox11.Checked;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            textBox25.Visible = checkBox12.Checked;
            radioButton3.Visible = checkBox12.Checked;
            radioButton4.Visible = checkBox12.Checked;
        }

      

        private void button21_Click(object sender, EventArgs e)
        {
          string f = "where ", f1 = "", f2 = "";
          if (checkBox11.Checked)
                f1 = " Nomre like '" + textBox24.Text + "'";
          if (checkBox12.Checked)
                f2 = " id like '" + textBox25.Text + "'";


         if (f1 != "") { if (f == "where ") f = f + f1; else f = f + " and " + f1; }
         if (f2 != "") { if (f == "where ") f = f + f2; else f = f + " and " + f2; }


          if (f == "where ")  goster1("Select* from kiraye ");
            else goster1("Select* from kiraye " +f);
          textBox25.Clear();

        }

        private void dataGridView2_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
          groupBox9.Visible = true;
          setir1 = e.RowIndex;
          sutun1 = e.ColumnIndex;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            id = 2; textBox25.Text = id.ToString();
            
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            id = 0; textBox25.Text = id.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            goster1("select* from kiraye");
        }
    
           

        }
    }

