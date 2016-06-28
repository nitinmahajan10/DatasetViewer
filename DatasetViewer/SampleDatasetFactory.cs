using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DatasetViewer
{
    public class SampleDatasetFactory
    {
        public static DataSet CreateSample(int numOfTables, int numOfCol)
        {
            numOfCol = Math.Min(50, numOfCol);//maximum 50 columns are allowed
            numOfCol = Math.Max(2, numOfCol);//minimum two columns should be there
            numOfTables = Math.Min(5, numOfTables); //maximum 5 data table are allowed in DS

            var sampleDs = new DataSet("Sample Dataset");
            for (int index = 0; index < numOfTables; index++)
            {
                var sampleDt = new DataTable("Table" + index);
                AddColunns(sampleDt, numOfCol);
                AddRows(sampleDt, numOfCol, 50);
                sampleDs.Tables.Add(sampleDt);
            }
            return sampleDs;
        }
        
        private static void AddColunns(DataTable theTable, int numOfCol)
        {
            for (int colIndex = 0; colIndex < numOfCol; colIndex++)
            {
                var theColumn = theTable.Columns.Add();
                if (colIndex == 0)
                {
                    theColumn.ColumnName = "RowId";
                    theColumn.DataType = typeof(int);
                }
                else if (colIndex == 1)
                {
                    theColumn.ColumnName = "ModifiedDate";
                    theColumn.DataType = typeof(DateTime);
                }
                else
                {
                    theColumn.ColumnName = "Column" + colIndex;
                    theColumn.DataType = typeof(string);
                }
            }
        }

        public static void AddRows(DataTable theTable, int numOfCol, int numOfRows)
        {
            for (int rowInd = 0; rowInd < numOfRows; rowInd++)
            {
                var theRow = theTable.NewRow();                
                theRow[0] = rowInd + 1;
                theRow[1] = DateTime.Now.AddHours(-rowInd);
                var theRandom = new Random(rowInd);
                for (int colIndex = 2; colIndex < numOfCol; colIndex++)
                {
                    theRow[colIndex] = theRandom.Next();
                }

                theTable.Rows.Add(theRow);
            }
        }
    }
}