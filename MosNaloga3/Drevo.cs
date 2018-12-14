using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MosNaloga3

{

    
    public partial class Drevo : Form
    {
        List<Vozlisce> starsi = new List<Vozlisce>();
        List<Vozlisce> vozlisca = new List<Vozlisce>();
        List<Vozlisce> otroci = new List<Vozlisce>();
        List<double[]> vmesnirezultati = new List<double[]>();
        //ArrayList rezultati = new ArrayList();

        List<Alternativa> alternative = new List<Alternativa>();

       

        Vozlisce glavni = new Vozlisce(null,0);
        int a = 0;
        int count = 0;

        int stevec = 0;
        DataTable test = new DataTable();
        DataTable testerino = new DataTable();
        DataTable zadnja = new DataTable();

        

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
                
                dreva.Nodes.Add(glavni.ime.ToString());
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
            Vozlisce vozlisce = new Vozlisce(textBox2.Text,0);
            
            dreva.SelectedNode.Nodes.Add(vozlisce.ime.ToString());

            if (dreva.SelectedNode.Level == 0)
            {
                glavni.otroci.Add(vozlisce);
            }
            else if (dreva.SelectedNode.Level==1)
            {
                int a =dreva.SelectedNode.Index;
                glavni.otroci[a].otroci.Add(vozlisce);
                vozlisca.Add(vozlisce);

            }
            else
            {
                int b = dreva.SelectedNode.Index;
                int c =dreva.SelectedNode.Parent.Index;
                glavni.otroci[c].otroci[b].otroci.Add(vozlisce);
                
              
            }
            dreva.ExpandAll();
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shrani_Click(object sender, EventArgs e)
        {

            if (stevec == 0)
            {
                test.Columns.Add(" ");
                //test.Columns[0].ReadOnly = true;
                for (int i = 0; i < glavni.otroci.Count; i++)
                {
                    test.Columns.Add(glavni.otroci[i].ime.ToString());
                    test.Rows.Add(glavni.otroci[i].ime.ToString());
                    test.Rows[i][i + 1] = 1;



                }
                podatki.DataSource = test;
                stevec++;
            }
            
            else if (stevec == 1)
            {
                int skupajotrok = 0;
                for(int u = 0; u < glavni.otroci.Count; u++)
                {
                    skupajotrok++;
                }


                podatki.DataSource = testerino;
                double[] m = Metode.preberi(testerino, skupajotrok);

                int test = 0;
                for (int a = 0; a < glavni.otroci.Count; a++)
                {
                    
                    
                    //double[] m = Metode.preberi(testerino, skupajotrok);

                        
                        for(int i = 0; i < glavni.otroci[a].otroci.Count; i++)
                        {
                            glavni.otroci[a].otroci[i].vrednost = m[test + i];
                            MessageBox.Show(m[test+i].ToString());
                        
                        test += glavni.otroci[a].otroci.Count;
                        }
                        
                       
                        
                    
                }

                

            }
           
            





        }
        
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            //Metode.preberi(test, stevec);
            //Metode.dopolni(test);
            
            
            podatki.DataSource = test;

            double[] m = Metode.preberi(test, glavni.otroci.Count);

            for(int i = 0; i < m.Length; i++)
            {
                glavni.otroci[i].vrednost = m[i];
                MessageBox.Show(glavni.otroci[i].vrednost.ToString());
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Metode.izbrisitabelo(test);
            podatki.DataSource = null;
            //DataTable testerino = new DataTable();
            //test.Columns.Add(" ");
            int f = -1;
            testerino.Columns.Add(" ");
            for (int i = 0; i < glavni.otroci.Count; i++)
            {
                
                for (int m=0; m < glavni.otroci[i].otroci.Count;m++)
                {
                    testerino.Columns.Add(glavni.otroci[i].otroci[m].ime.ToString());   
                    testerino.Rows.Add(glavni.otroci[i].otroci[m].ime.ToString());
                    f++;
                    testerino.Rows[f][f + 1] = 1;
                }
                //testerino.Rows[f][f + 1] = 1;


            }
            podatki.DataSource = testerino;

  
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int z = 0; z < vozlisca.Count; z++)
            {
                
                if (vozlisca[z].otroci.Count == 0)
                {
                    otroci.Add(vozlisca[z]);
                }
            }

            for(int tt = 0; tt < glavni.otroci.Count; tt++)
            {
                if (glavni.otroci[tt].otroci.Count==0)
                {
                    otroci.Add(glavni.otroci[tt]);
                }
            }
           

            MessageBox.Show(otroci[0].ime.ToString());
            MessageBox.Show(otroci[1].ime.ToString());
            MessageBox.Show(otroci.Count.ToString());


            for (int i = 0; i < otroci.Count; ++i)
            {
                if (!comboBox1.Items.Contains(otroci[i]))
                {
                    comboBox1.Items.Add(otroci[i].ime.ToString());
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            //napolni listbox + dodaj v List alternativ
            listBox1.Items.Clear();
            //List<double> vrednosti = new List<double>(alternative.Count);
            double vrednosti = 0;
            Alternativa nova = new Alternativa(textBox3.Text, vrednosti);
            alternative.Add(nova);
            

            for (int i = 0; i < alternative.Count; ++i)
            {
                if (!listBox1.Items.Contains(nova))
                {
                    listBox1.Items.Add(alternative[i].ime.ToString());
                }
            }
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {



            //Metode.izbrisitabelo(zadnja);
            //zadnja.Reset();
            zadnja.Rows.Clear();
            zadnja.Columns.Clear();
            zadnja.Columns.Add(" ");
            MessageBox.Show(otroci[comboBox1.SelectedIndex].ime.ToString());

            
           
            int f = -1;
                for (int o = 0; o < alternative.Count; o++)
                {
                    zadnja.Columns.Add(alternative[o].ime.ToString());
                    zadnja.Rows.Add(alternative[o].ime.ToString());
                    f++;
                    zadnja.Rows[f][f+1] = 1;



                }
                podatki.DataSource = zadnja;

            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double [] rezultati2 = Metode.preberi(zadnja, alternative.Count);
            vmesnirezultati.Add(rezultati2);
            /*
            for(int z = 0; z < rezultati2.Length; z++)
            {


                rezultati[z] = rezultati2[z];
                

            }
            */
            
            
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            int stevecalt = 0;

            for(int i = 0; i < glavni.otroci.Count; i++)
            {
                double k = 0;
                double rezultat = 0; 

                rezultat = glavni.otroci[i].vrednost;
                for(int z = 0; z < glavni.otroci[i].otroci.Count; z++)
                {
                    
                     //k =+ glavni.otroci[i].otroci[z].vrednost*vmesnirezultati[i][z];
                       k =+ glavni.otroci[i].otroci[z].vrednost * vmesnirezultati[z][i];
                }

                rezultat = rezultat + k;

               
                alternative[stevecalt].vrednost= rezultat;
                
                //alternative[i].vrednost = rezultat;
                MessageBox.Show(alternative[stevecalt].vrednost.ToString());
                stevecalt++;

            }


            for (int mm = 0; mm < alternative.Count; mm++)
            {
                chart1.Series["Vrednosti"].Points.AddXY(alternative[mm].ime.ToString(), alternative[mm].vrednost);
            }


            /*
            int index = 0;
            for (int g = 0; g < alternative.Count; g++)
            {
                
                double trenutna = 0;
                double vrednost = alternative[g].vrednost;
                
                if (vrednost>trenutna)
                {
                    trenutna = vrednost;
                    index++;
                }

                
            }

            MessageBox.Show("najboljša alternativa je " + alternative[index].ime.ToString());
            */
          

                
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {


            //Shrani graf
            SaveFileDialog saveChart = new SaveFileDialog();
            saveChart.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveChart.Title = "shrani graf";
            saveChart.ShowDialog();
            if(saveChart.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveChart.OpenFile();
                this.chart1.SaveImage(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                string path = System.IO.Path.GetFullPath(saveChart.FileName);
                MessageBox.Show(" graf uspešno shranjen na mesto " + path);
            }

          



            //shrani alternative
            using (TextWriter tw = new StreamWriter("Alternative.txt"))
            {
                foreach (Alternativa nova  in alternative)
                {
                    tw.WriteLine(nova);
                }
                tw.Close();
            }


            //serializiraj drevo
            StringBuilder sb = new StringBuilder();

            foreach (TreeNode node in dreva.Nodes)
            {
                sb.AppendLine(node.Name);
            }


            SaveFileDialog saveList = new SaveFileDialog();

            saveList.DefaultExt = "*.mvia";
            saveList.Filter = "MVIA Files|*.mvia";

            if (saveList.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveList.FileName, sb.ToString());
            }


            
           

           
        }

        private void dopolni_Click(object sender, EventArgs e)
        {
            

            if (count == 0)
            {
                Metode.dopolni(test);
                podatki.DataSource = test;
                count++;
            }
            else
            {
                Metode.dopolni(testerino);
                podatki.DataSource = testerino;
            }
        }   
    }
}