using System.Data.SqlTypes;

namespace Database
{
    public partial class UserDefinedFunctions
    {
        [Microsoft.SqlServer.Server.SqlFunction]
        public static SqlString Create()
        {
            // Put your code here
            return new SqlString (string.Empty);
        }
    }
}
