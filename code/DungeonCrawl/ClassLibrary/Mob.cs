
namespace ClassLibrary
{
    public class Mob: AliveObject
    {
        public static void Display()
        {
            foreach (var item in Global.mobs)
            {
                System.Console.WriteLine($"{item.Name}");
            }
        }
    }
}
