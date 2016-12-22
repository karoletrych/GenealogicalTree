using Application;
using Xunit;

namespace Tests.Database
{
    public class Database
    {
        [Fact]
        public void DatabaseReturnsParentlessPeople()
        {
            RootPersonsRetriever.Retrieve();
        }
    }
}