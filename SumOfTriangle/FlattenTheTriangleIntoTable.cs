using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTriangle
{
    public class FlattenTheTriangleInto
    {

      public  static int[,] FlattenTheTriangleIntoTable(string[] arrayOfRowsByNewlines)
        {
            int[,] tableHolder = new int[arrayOfRowsByNewlines.Length, arrayOfRowsByNewlines.Length + 1];

            for (int row = 0; row < arrayOfRowsByNewlines.Length; row++)//Gelen datada donuyoruz
            {
                var eachCharactersInRow = arrayOfRowsByNewlines[row].Trim().Split(' ');//gelen datayı split ediyoruz

                for (int column = 0; column < eachCharactersInRow.Length; column++)
                { //spilit ettigimiz datayı donuyoruz
                    int number;
                    int.TryParse(eachCharactersInRow[column], out number);// tipini inte parse edip outla fırlatıyoruz numberi 
                    tableHolder[row, column] = number;// number i tableholder a esitliyoruz
                }
            }
            return tableHolder;
        }
    }
}
