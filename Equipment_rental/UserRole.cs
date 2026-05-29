namespace Equipment_rental
{
    public enum UserRole
    {
        User = 0,
        Operator = 1,
        Administrator = 2
    }

    public static class UserRoleHelper
    {
        public const string UserDbValue = "user";
        public const string OperatorDbValue = "operator";
        public const string AdministratorDbValue = "admin";

        public static UserRole FromDbValue(string? value)
        {
            return value?.Trim().ToLowerInvariant() switch
            {
                AdministratorDbValue or "administrator" or "администратор" => UserRole.Administrator,
                OperatorDbValue or "оператор" => UserRole.Operator,
                _ => UserRole.User
            };
        }

        public static string ToDbValue(UserRole role) => role switch
        {
            UserRole.Administrator => AdministratorDbValue,
            UserRole.Operator => OperatorDbValue,
            _ => UserDbValue
        };

        public static string ToDisplayName(UserRole role) => role switch
        {
            UserRole.Administrator => "Администратор",
            UserRole.Operator => "Оператор",
            _ => "Пользователь"
        };

        public static bool CanCreate(UserRole role) =>
            role is UserRole.Administrator or UserRole.Operator;

        public static bool CanUpdate(UserRole role) =>
            role is UserRole.Administrator or UserRole.Operator;

        public static bool CanDelete(UserRole role) =>
            role == UserRole.Administrator;

        public static bool CanSearch(UserRole role) => true;
    }
}
