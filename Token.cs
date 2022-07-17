namespace Mini_Securonix_API;

public class Token
{
    public string id {get;}
    public string username {get;}
    public DateTime expirationdate {get;set;}

    public Token(string u, int validity=365) {
        Random random = new Random();

        // Set token username
        username = u;

        // Adjust expirationdate by displayed timespan
        expirationdate = DateTime.Now + new TimeSpan(validity, 0, 0, 0);

        // "randomly" generate 16 hex values
        id = "";
        for(int i = 0; i < 32; i++)
            id += random.Next(16).ToString("X");
    }

    public string PrettyString() {
        
        // String format in hex
        // ########-####-####-####-############
        return $"{id.Substring(0,8)}-{id.Substring(8,4)}-{id.Substring(12,4)}-"
                + $"{id.Substring(16,4)}-{id.Substring(20,12)}";

    }
}
