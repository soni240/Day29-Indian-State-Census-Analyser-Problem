using IndianStateCensusAnalyzer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyzer
{
    public class CensusAnalyser
    {
        public static int a = 10;
        /// <summary>
        /// enum Country Constant for diffrent country.
        /// </summary>
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;
        /// <summary>
        /// Loads the census data.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
        {
            //CensusAnalyser obj = new CensusAnalyser();
            //Console.WriteLine(obj.a);
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }

    }










}

