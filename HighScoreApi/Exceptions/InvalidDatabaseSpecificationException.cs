namespace HighScoreApi.Exceptions
{
    /// <summary>
    /// This class is intended to trigger when the user doesn't specify their data source in the config file
    /// </summary>
    public class InvalidDatabaseSpecificationException : Exception
    {
        public InvalidDatabaseSpecificationException()
        {
            
        }

        public InvalidDatabaseSpecificationException(string message)
               : base(message) 
        {

        }

        public InvalidDatabaseSpecificationException(string message, Exception innerException)
               : base(message, innerException)
        {

        }

    }
}
