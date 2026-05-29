namespace Equipment_rental
{
    public static class UserSession
    {
        public static bool IsAuthenticated { get; private set; }
        public static int UserId { get; private set; }
        public static string UserName { get; private set; } = "";
        public static string UserLogin { get; private set; } = "";
        public static UserRole Role { get; private set; } = UserRole.User;

        public static void SignIn(int userId, string userName, string login, UserRole role)
        {
            UserId = userId;
            UserName = userName;
            UserLogin = login;
            Role = role;
            IsAuthenticated = true;
        }

        public static void Logout()
        {
            UserId = 0;
            UserName = "";
            UserLogin = "";
            Role = UserRole.User;
            IsAuthenticated = false;
        }
    }
}
