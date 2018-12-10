using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosNaloga3
{
    class Metode
    {


        public static DataTable dopolni(DataTable x, int i)
        {
            DataTable nova = new DataTable();

            int meja = 5;
            for (int a = 0; a < 5; a++)
            {

            }

            return nova;
        }

        public static List<double> preberi(DataTable x, int i)
        {
                 List<double> y = new List<double>(i);

                for (int m =1;m<x.Rows.Count;m++)
                {
                    
                    
                    
                    double skupaj = 0;

                        
                        for (int a = 1; a < x.Columns.Count; a++)
                        {
                        
                       
                         double v = Convert.ToDouble(x.Rows[m][a]);
                         skupaj += v;

                            if (a == x.Columns.Count-1)
                            {
                                skupaj = skupaj / a;
                            }
                        
                         

                        }
                    y[m-1] = skupaj;
                }

                
        


            return y;

        }




    }

}

        
    

