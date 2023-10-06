namespace API.Entities;

public class AppUser
{
    public string Id { get; set; }
    public string UserName { get; set; }

    public AppUser(string Id, string UserName)
    {
        this.Id = Id;
        this.UserName = UserName;
    }

}