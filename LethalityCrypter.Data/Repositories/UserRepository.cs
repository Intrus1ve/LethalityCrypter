using ColoredPlugins.Data;
using Dapper;
using LethalityCrypter.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LethalityCrypter.Data.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection connection;

        public UserRepository()
        {
            connection = new SqlConnection(AppConnection.ConnectionString);
        }

        public async Task<Shared> GetSharedsAsync(string token) 
        {
            return await connection.QuerySingleOrDefaultAsync<Shared>($"SELECT * FROM dbo.Shareds WHERE BuyDate >= DATEADD(month, -MonthCount, GETDATE()) AND Token = @token", new { token });
        }

        public async Task<Private> GetPrivatesAsync(string token) 
        {
            return await connection.QuerySingleOrDefaultAsync<Private>($"SELECT * FROM dbo.Privates WHERE BuyDate >= DATEADD(month, -MonthCount, GETDATE()) AND Token = @token", new { token });
        }
    }
}
