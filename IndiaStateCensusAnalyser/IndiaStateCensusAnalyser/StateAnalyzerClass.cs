﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiaStateCensusAnalyser
{
    public class StateAnalyserClass
    {
        public int DataAnalyser(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var details = csv.GetRecords<StateModel>().ToList();
                var numberOfRecords = details.Count();
                foreach (var item in details)
                {
                    Console.WriteLine("State: " + item.State + "\nPopulation: " + item.Population + "\nAreaInSqKm: " + item.AreaInSqKm
                        + "\nDensityPerSqKm: " + item.DensityPerSqKm + "\n");
                }
                return numberOfRecords;
            }
        }
    }
}