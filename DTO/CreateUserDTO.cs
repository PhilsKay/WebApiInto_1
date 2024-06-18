namespace WebApiInto_1.DTO
{
    public record CreateUserDTO
    {
        public string Email {get; set; }
        public string Password { get; set; }
    }
}
