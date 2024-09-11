namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           RandomList strings = new RandomList 
           { 
            "nedelcho",
            "popov",
            "vasil",
            "deni"
           };

            strings.RandomString();
        }
    }
}
