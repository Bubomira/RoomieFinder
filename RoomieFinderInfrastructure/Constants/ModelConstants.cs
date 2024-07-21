
namespace RoomieFinderInfrastructure.Constants
{
    public static class ModelConstants
    {
        public static class ApplicationUserConstants
        {
            public const int FirstNameMaxLength = 50;
            public const int FirstNameMinLength = 2;

            public const int LastNameMaxLength = 60;
            public const int LastNameMinLength = 2;

            public const int UsernameMaxLength = 30;
            public const int UsernameMinLength = 2;

            public const int PasswordMaxLength = 20;
            public const int PasswordMinLength = 8;
        }

        public static class UniversityConstants
        {
            public const int NameMaxLength = 100;
            public const int NameMinLength = 5;
        }

        public static class DormitoryConstants
        {
            public const int NameMaxLength = 30;
            public const int NameMinLength = 4;
        }

        public static class RoomConstants
        {
            public const int NoCapacityLeft = 0;
        }

        public static class RequestConstants
        {
            public const int CommentMaxLength = 100;
        }

        public static class StudentConstants
        {
            public const int TopYearAtUniversity = 4;
        }


        public static class QualityConstants
        {
            public const int NameMaxLength = 30;
            public const int NameMinLength = 2;
        }
    }
}
