using static Newtonsoft.Json.JsonConvert;

namespace library
{
    public class Thing
    {
        //public method
        public int Get(int a, int b) =>
            DeserializeObject<int>($"{a + b}");
    }
}

// The `Thing` class contains one public method, `Get`, 
// which returns the sum of two numbers but does so by 
// converting the sum into a string and then deserializing 
// it into an integer. 

// This makes use of a number of modern C# features, 
// such as using static directives, 
// expression-bodied members, and string interpolation.
