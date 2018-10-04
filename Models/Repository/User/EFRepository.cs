using APICRUD.Models.DAL;
using System.Linq;
using System.Threading.Tasks;

namespace APICRUD.Models
{
    public class EFUserRepository : IRepository<User>
    {
        private readonly UserContext userContext;

        public EFUserRepository(UserContext _employeeContext)
        {
            this.userContext = _employeeContext;
        }

        public async Task<User> GetAsync(int userId)
        {
            return await userContext.Users.FindAsync(userId);            
        }

        public async Task AddAsync(User user)
        {
            userContext.Users.Add(user);
            await userContext.SaveChangesAsync();
        }
     
        public async Task UpdateAsync(User userId)
        {
            var employeeEntry = await userContext.Users.FindAsync(userId.Id);
            employeeEntry = userId;
            await userContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            userContext.Users.Remove(userContext.Users.Single(a => a.Id == id));
            await userContext.SaveChangesAsync(); 
        }
    }
}