﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MosNaloga3
{
    class Metode
    {


        public static DataTable dopolni(DataTable x)
        {
            DataTable nova = new DataTable();





            for (int m = 1; m <= x.Rows.Count; m++)
            {
                
                for (int a = 1; a < x.Columns.Count; a++)
                {
                    if (x.Rows[m-1][a].ToString()!=null)
                    {
                        MessageBox.Show(x.Rows[m][a].ToString());
                    }
                }

            }



                    return nova;
        }



        public static double [] preberi(DataTable x, int i)
        {
            double [] y = new double[i];

            int stevec = 0;
                for (int m =1;m<=x.Rows.Count;m++)
                {
                    
                    
                    
                    double skupaj = 0;
                    
                        
                        for (int a = 1; a < x.Columns.Count; a++)
                        {

                         //double Myvalue = double.Parse(x.Rows[m][a].ToString());

                         //double v = double.Parse(x.Rows[a - 1][m]); 
                         double v =Convert.ToDouble(x.Rows[a-1][m]);
                         double pomozna = 0;
                         

                         for(int z = 1; z < x.Columns.Count; z++)
                         {
                          pomozna += Convert.ToDouble(x.Rows[z-1][a]);

                         }

                        double prava = v / pomozna;
                        //double prava = Myvalue / pomozna;
                         skupaj += prava;

                        if (a+1 == x.Columns.Count)
                                {
                                    skupaj = skupaj / a;
                                }
                        
                         

                            }
                    
                        y[stevec] = skupaj;
                        stevec++;
                }

                
        


            return y;

        }

        internal static void napolnitabelo(DataTable x)
        {
            throw new NotImplementedException();
        }




        public static void izbrisitabelo(DataTable table)
        {
            try
            {
                table.Reset();
                table.Clear();
            }
            catch (DataException e)
            {
                
                Console.WriteLine("Napaka.", 
                    e.GetType());
            }

        }



    }

}

        
    

