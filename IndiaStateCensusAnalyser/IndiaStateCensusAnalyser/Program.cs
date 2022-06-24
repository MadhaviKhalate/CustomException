using System;

namespace IndiaStateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StateAnalyserClass getMethod = new StateAnalyserClass();
            Console.WriteLine("1.State Census Analyser\n2.State Code Analyser\nEnter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    {
                        string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\IndiaStateCensusAnalyser
                                               \IndiaStateCensusAnalyser\StateCensusData.csv";
                        getMethod.DataAnalyser(filePath);
                        break;
                    }
                case 2:
                    {
                        string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\IndiaStateCensusAnalyser
                                                \IndiaStateCensusAnalyser\StateCode.csv";
                        getMethod.StateCodeAnalyser(filePath);
                        break;
                    }
            }

        }
    }
}

