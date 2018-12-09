using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosNaloga3

{
    
    
    public partial class Drevo : Form
    {
        
        List <Stars> vozlisca = new List<Stars>();
        List <Stars> starsi = new List <Stars>();
        Stars glavni = new Stars(null,0);
        int a = 0;
      
        public Drevo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if (a < 1)
            {
                glavni.ime=(textBox1.Text);
                
                treeView.Nodes.Add(glavni.ime.ToString());
                //starsi.Add(glavni);
                
                a++;
            }
            else
            {
                MessageBox.Show("Dovoljen je samo 1 element");
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Stars vozlisce = new Stars(textBox2.Text,0);
            
            treeView.SelectedNode.Nodes.Add(vozlisce.ime.ToString());

            if (treeView.SelectedNode.Level == 0)
            {
                glavni.otroci.Add(vozlisce);
            }
            else if (treeView.SelectedNode.Level==1)
            {
                int a =treeView.SelectedNode.Index;
                glavni.otroci[a].otroci.Add(vozlisce);
                
            }
            else
            {
                int b = treeView.SelectedNode.Index;
                //int b = treeView.SelectedNode.Index;
                //treeView.SelectedNode.
            }
            treeView.ExpandAll();
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shrani_Click(object sender, EventArgs e)
        {

            

            
            int m = treeView.SelectedNode.Index;
            int g=glavni.otroci[m].otroci.Count();
            MessageBox.Show(g.ToString());

           
        }
        
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}