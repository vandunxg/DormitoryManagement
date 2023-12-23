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
