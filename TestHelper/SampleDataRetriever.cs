namespace TestHelper
{
    public static class SampleDataRetriever
    {
        // TODO: Implement a static method that pulls in data from a JSON file for database population

        // TODO: Implement a static method that pulls from an existing JSON string in this file (if you want to test without I/O operations)
        public static string GetTestData()
        {
            return _sampleData;
        }

        private static string _sampleData = "";
    }

    
}
