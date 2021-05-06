using RRBL;
using RRDL;
namespace RRUI
{
    public class MenuFactory
    {
        public static IMenu GetMenu(string menuType)
        {
            switch (menuType.ToLower())
            {
                case "main":
                    return new MainMenu();
                case "restaurant":
                    return new RestaurantMenu(new RestaurantBL(new RepoFile()), new ValidationService());
                default:
                    return null;
            }
        }
    }
}