using Newtonsoft.Json;

namespace ProjectB;

public class Greeter
{
    public string Hello(string name)
    {
        var payload = new { message = $"Hello, {name}!" };
        return JsonConvert.SerializeObject(payload);
    }
}
