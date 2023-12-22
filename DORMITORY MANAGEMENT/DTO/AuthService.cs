using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DORMITORY_MANAGEMENT.DTO
{
    public class AuthService
    {
        private static int loggedInUserId;

        public static void SetLoggedInUserId(int userId)
        {
            loggedInUserId = userId;
        }

        public static int GetLoggedInUserId()
        {
            return loggedInUserId;
        }
    }
}
