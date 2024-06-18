using Microsoft.EntityFrameworkCore;
using WebApiInto_1.Data;
using WebApiInto_1.IServices;
using WebApiInto_1.Model;

namespace WebApiInto_1.Services
{
    public class UserService : IUser
    {
        private readonly DataContext dataContext;
        public UserService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void AddUser(User user)
        {
            //var _user = dataContext.Database.SqlQuery<TransactionDTO>($"SELECT TransactionId,Amount ,TransactionType,UserId  FROM webapitest1.Transactions").ToList();
            //FormattableString uu = $"SELECT SUM(Amount) FROM webapitest1.Transactions";
            //var _usder = dataContext.Transactions.FromSql(uu).ToList();

           // dataContext.Transactions.Update();
        }
    }
}
