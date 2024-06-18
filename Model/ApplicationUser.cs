namespace WebApiInto_1.Model
{
    public class ApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public DateTime DateCreated { get; set; }
    }
}
