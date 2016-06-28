using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DatasetViewer.API
{
    public class DatasetController : ApiController
    {
        //http://localhost:61362/Api/Dataset/GetDataset?numOfTables=3&numOfCol=5
        public DataSet GetDataset(int numOfTables, int numOfCol)
        {
            return SampleDatasetFactory.CreateSample(numOfTables, numOfCol);
        }
    }
}
