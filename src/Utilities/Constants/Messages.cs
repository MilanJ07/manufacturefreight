using Utilities.Enums;
using Utilities.MessageStatus;

namespace Utilities.Constants
{
    public static class Messages
    {
        private static readonly Dictionary<string, ErrorDetail> ValidationErrors = CreateDictionary();

        public static ErrorDetail EntityNotFound => new ErrorDetail(Codes.EntityNotFound, Category.Error, Descriptions.EntityNotFound, "plant");

        public static ErrorDetail HasInvalidName
        {
            get
            {
                return new(Codes.DataValidationError, Category.Error, Descriptions.EntityNotFound, "Name");
            }
        }

        public static ErrorDetail InvalidCount
        {
            get
            {
                return new(Codes.InvalidCount, Category.Warning, Descriptions.InvalidCount, "count");
            }
        }

        public static ErrorDetail InvalidOffset
        {
            get
            {
                return new(Codes.InvalidOffset, Category.Warning, Descriptions.InvalidOffset, "offset");
            }
        }

        public static ErrorDetail GetErrorDetail(string code, string description, string element, Category category = Category.Error)
        {
            return new ErrorDetail(code, category, description, element);
        }

        private static Dictionary<string, ErrorDetail> CreateDictionary() 
        {
            var dictionary = new Dictionary<string, ErrorDetail>()
            {

            };
            return dictionary;
        }

        private readonly struct Descriptions
        {
            public const string EntityNotFound = "Requested record was not found or inaccessible";
            public const string InvalidCount = "Invalid or missing count, using default value of 50";
            public const string InvalidOffset = "Invalid or missing count, using default value of 0";
        }
    }
}
