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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            matiere_eleve.Items.Add("212");
            matiere_eleve.Items.Add("2");
            matiere_eleve.Items.Add("3");



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            note_f.Text = "";
           
            code_eleve.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            note n = new note();
            n.Code_eleve = Int32.Parse(code_eleve.Text);
            n.Code_matiere = Int32.Parse(matiere_eleve.SelectedItem.ToString());
            n.Note = float.Parse(note_f.Text);
            n.save();
        }

        private void matiere_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void Notes_Load(object sender, EventArgs e)
        {

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
