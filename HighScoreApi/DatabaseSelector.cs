using HighScoreApi.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace HighScoreApi
{
    public static class DatabaseSelector
    {
        public static DbContextOptionsBuilder GetContextByType(WebApplicationBuilder builder, 
            string dbType)
        {
            switch (dbType)
            {
                case "InMemory":
                    // TODO: implement a pre-populated in-memory DB
                    throw new NotImplementedException();
                    break;
                default:
                    throw new InvalidDatabaseSpecificationException();
            }
            
        }
    }
}
