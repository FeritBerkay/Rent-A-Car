using Core.Entities;

public class UserForRegisterDto : IDto
{
    //Dto cunku datamda password yok. Ve register bilgilerini degistirebilirim.
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
