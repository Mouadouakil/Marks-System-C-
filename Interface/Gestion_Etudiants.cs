using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Gestion_Etudiants : Form
    {

        private void GetAllData(Dictionary<string, Object> dic = null)
        {

            DataTable table = new DataTable();
            try
            {
                DataColumn c0 = new DataColumn("id");
                DataColumn c1 = new DataColumn("code");
                DataColumn c2 = new DataColumn("nom");
                DataColumn c3 = new DataColumn("prenom");
                DataColumn c4 = new DataColumn("niveau");
                DataColumn c5 = new DataColumn("code_fil");



                table.Columns.Add(c0);
                table.Columns.Add(c1);
                table.Columns.Add(c2);
                table.Columns.Add(c3);
                table.Columns.Add(c4);
                table.Columns.Add(c5);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            

            eleve etu = new eleve();
            List<Dictionary<string, Object>> list;
            if (dic == null)
            {
                list = etu.All();
            }
            else
            {
                list = etu.Select(dic);
            }

            foreach (Dictionary<string, Object> element in list)
            {

                int i = 0;
                DataRow row = table.NewRow();

                foreach (KeyValuePair<string, Object> temp in element)
                {
                    
                    row[i++] = (temp.Value).ToString();
                }

                Console.WriteLine(row[1]);
                table.Rows.Add(row);

            }

            DataGrid1.DataSource = table;
        }







        private void Delete(Dictionary<string, Object> dic = null)
        {

            DataTable table = new DataTable();
            try
            {
                DataColumn c0 = new DataColumn("id");
                DataColumn c1 = new DataColumn("code");
                DataColumn c2 = new DataColumn("nom");
                DataColumn c3 = new DataColumn("prenom");
                DataColumn c4 = new DataColumn("niveau");
                DataColumn c5 = new DataColumn("code_fil");



                table.Columns.Add(c0);
                table.Columns.Add(c1);
                table.Columns.Add(c2);
                table.Columns.Add(c3);
                table.Columns.Add(c4);
                table.Columns.Add(c5);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



            eleve etu2 = new eleve();
            List<Dictionary<string, Object>> list;


            etu2.Delete(dic);
            list = etu2.All();

            foreach (Dictionary<string, Object> element in list)
            {

                int i = 0;
                DataRow row = table.NewRow();

                foreach (KeyValuePair<string, Object> temp in element)
                {

                    row[i++] = (temp.Value).ToString();
                }

                Console.WriteLine(row[1]);
                table.Rows.Add(row);

            }

            DataGrid1.DataSource = table;
        }




        public Gestion_Etudiants()
        {
            InitializeComponent();
            
            GetAllData();
            filiere_eleve.Items.Add("GINF");
            filiere_eleve.Items.Add("GSTR");
            filiere_eleve.Items.Add("GSEA");
            filiere_eleve.Items.Add("GIND");
            filiere_eleve.Items.Add("GSTR");
            filiere_eleve.Items.Add("G3EI");
            niveau_eleve.Items.Add("1");
            niveau_eleve.Items.Add("2");
            niveau_eleve.Items.Add("3");
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Gestion_Etudiants_Load(object sender, EventArgs e)
        {

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            code_eleve.Text = "";
            nom_eleve.Text = "";
            prenom_eleve.Text = "";
            GetAllData();






        }

        private void button1_Click(object sender, EventArgs e)
        {
            eleve el = new eleve();
            el.Code = Int32.Parse(code_eleve.Text);
            el.Niveau = Int32.Parse(niveau_eleve.SelectedItem.ToString());
            el.Nom = nom_eleve.Text;
            el.Prenom = prenom_eleve.Text;
            el.Code_fil = filiere_eleve.SelectedItem.ToString();



            el.save();

            GetAllData();


        }

        private void filiere_eleve_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void niveau_eleve_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void button3_Click(object sender, EventArgs e)
        {


            Dictionary<string, Object> dicDelete = new Dictionary<string, object>();
            dicDelete.Add("code", code_eleve.Text);
            Delete(dicDelete);







        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            

            Dictionary<string, Object> dic = new Dictionary<string, object>();
            dic.Add("code", code_eleve.Text);
            GetAllData(dic);




        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Notes().ShowDialog();
        }
    }
}
