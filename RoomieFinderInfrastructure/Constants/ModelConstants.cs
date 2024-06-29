
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
            public const int NameMaxLength= 100;
            public const int NameMinLength = 5;
        }

        public static class DormitoryConstants
        {
            public const int NameMaxLength = 30;
            public const int NameMinLength = 4;
        }

        public static class QuestionConstants
        {
            public const int TitleMaxLength = 200;
            public const int TitleMinLength = 20;
        }

        public static class AnswerConstants
        {
            public const int ContentMaxLength = 100;
            public const int ContentMinLength = 5;
        }

        public static class QuestionnaireConstants
        {
            public const int TitleMaxLength = 50;
            public const int TitleMinLength = 3;

            public const int DescriptionMaxLength = 300;
            public const int DescriptionMinLength = 15;
        }
    }
}
