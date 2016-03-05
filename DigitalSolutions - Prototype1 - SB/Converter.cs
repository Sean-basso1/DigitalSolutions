using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class is designed for converting the DataSet datatype into 
 * useable data types that the program can use eg. Integer, Double, Date, string
 * It requires DataSet datatype as input when class is instantiated
 */
namespace DigitalSolutions___Prototype1___SB
{
    class Converter
    {
        //fields
        private DataSet dSet;

        //constructor
        public Converter(DataSet dSet)
        {
            this.dSet = dSet;
        }


        public string[,] convertDataSetToArray(int tableIndex, int columnNumber)
        {

            string[,] strArray = new string[dSet.Tables[tableIndex].Rows.Count, columnNumber];

            for (int i = 0; i < dSet.Tables[tableIndex].Rows.Count; i++)
            {

                for (int j = 0; j < columnNumber; j++)
                {
                    strArray[i, j] = dSet.Tables[tableIndex].Rows[i][j].ToString();
                }
            }

            return strArray;
        }
    }
}
