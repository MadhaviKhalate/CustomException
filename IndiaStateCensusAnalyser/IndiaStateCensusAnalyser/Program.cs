using System;

namespace IndiaStateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\
                                IndiaStateCensusAnalyser\IndiaStateCensusAnalyser\StateCensusData.csv";
            StateAnalyserClass getMethod = new StateAnalyserClass();
            getMethod.DataAnalyser(filePath);
        }
    }
}
