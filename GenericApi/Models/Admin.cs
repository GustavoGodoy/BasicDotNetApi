namespace GenericApi.Models;

public class Admin
{
    public int id { get; set; }
    public string name { get; set; }

    public Admin(){ }

    public Admin(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}