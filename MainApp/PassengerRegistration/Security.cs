using System;

namespace PassengerRegistration
{
    class Security
    {
        public static bool SecurityQuestions()
        {
            string resultForbiddenItems;
            string resultPermission;

            Console.WriteLine(Constants.SecurityQuestions.ForbiddenItems);
            resultForbiddenItems = Console.ReadLine().ToUpper();

            if (resultForbiddenItems.Equals("Y"))
            {
                Console.WriteLine(Constants.SecurityQuestions.Permission);
                resultPermission = Console.ReadLine().ToUpper();
                if (resultPermission.Equals("Y"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
    }
}
