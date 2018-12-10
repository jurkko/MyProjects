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
                 List<double> y = new List<double>();

                foreach (DataRow row in x.Rows)
                {
                    if (x.Rows.IndexOf(row) != 0)
                    {
                        //loop all the columns in the row
                        for (int a = 1; a < x.Columns.Count; a++)
                        {
                        //add the values for each cell to the total
                         
                            y[a+1] += Convert.ToDouble(row[x.Columns[a+1].ColumnName]);
                        }
                    }

                }
        


            return y;

        }




    }

}

        
    

