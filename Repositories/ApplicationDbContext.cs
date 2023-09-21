using FoodOrder.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FoodOrder.Repositories
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, int>
    {

    }
}
