namespace entities_library.login;

public class User//aca hereda de la clase persona los atributos nombre email 
{
    
    public required string Password {get; set;}

    public UserStatus UserStatus {get; set;} = UserStatus.Active;

    public UserRole UserRole {get; set;}
    public object? Mail { get; set; }
    public long Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }

    public void Encrypt(string Password)
    {
        this.Password = this.encrypt(Password);

    }
    public bool IsPassword(string password)
    {
        return this.encrypt(password) == this.Password;
    }

    private string encrypt(string password)
    {
        return password;
    }
}
