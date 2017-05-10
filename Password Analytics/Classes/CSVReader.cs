using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Linq;
using CsvHelper;

namespace Password_Analytics.Classes
{
    /// <summary>
    /// Reads CSV and returns it as List 
    /// </summary>
    internal class CSVReader
    {
        /// <summary>
        /// Chrome Export CSV file
        /// </summary>
        public string CsvFile { get; set; }

        public static List<ChromeExport> ReadFile(string csvFile)
        {
         var csv = new CsvReader( new StreamReader(csvFile) );
         var LstChromeExport = csv.GetRecords<ChromeExport>();
         return LstChromeExport.ToList();
        }

      
    }

}

