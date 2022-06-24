namespace IndianStateAndCodeTesting
{
    public class Tests
    {
        [Test]
        public void GivenStatesCensusCSVFile_CheckNumberOfRecordsMatches()
        {
            int expected = 29;
            string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\
                                    IndiaStateCensusAnalyser\StateCensusData.csv";
            IndiaStateCensusAnalyser.StateAnalyserClass getMethod = new IndiaStateCensusAnalyser.StateAnalyserClass();
            int actual = getMethod.DataAnalyser(filePath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenInvalidFile_ShouldThrowInvalidFileException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\IndiaStateCensusAnalyser\
                                    IndiaStateCensusAnalyser\StateCode.csv";
                IndiaStateCensusAnalyser.StateAnalyserClass getMethod = new IndiaStateCensusAnalyser.StateAnalyserClass();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidFileType_ShouldThrowInvalidFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\IndiaStateCensusAnalyser\
                                    IndiaStateCensusAnalyser\StateCensusData.txt";
                IndiaStateCensusAnalyser.StateAnalyserClass getMethod = new IndiaStateCensusAnalyser.StateAnalyserClass();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid File Type", ex.Message);
            }
        }
        [Test]
        public void GivenInvalidDelimiterFile_ShouldThrowInvalidDelimiterFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser
                                \IndiaStateCensusAnalyser\InvalidDelimiterCensusData.csv";
                IndiaStateCensusAnalyser.StateAnalyserClass getMethod = new IndiaStateCensusAnalyser.StateAnalyserClass();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Delimiter", ex.Message);
            }
        }
        [Test]
        public void GivenIncorrectHeaderFile_ShouldThrowIncorrectHeaderFileTypeException()
        {
            try
            {
                int expected = 29;
                string filePath = @"D:\BridgeLabzFelloship\IndianStatesCensusAnalyser\
                                    IndiaStateCensusAnalyser\IncorrectHeaderCensusData.csv";
                IndiaStateCensusAnalyser.StateAnalyserClass getMethod = new IndiaStateCensusAnalyser.StateAnalyserClass();
                int actual = getMethod.DataAnalyser(filePath);
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Incorrect Header", ex.Message);
            }
        }
    }
}