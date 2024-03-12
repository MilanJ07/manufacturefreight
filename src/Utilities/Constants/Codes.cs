namespace Utilities.Constants
{
    public readonly struct Codes
    {
        public const string DataValidationError = $"{Service.ServiceIdentifier}.0001";
        public const string EntityNotFound = $"{Service.ServiceIdentifier}.0002";
        public const string InvalidCount = $"{Service.ServiceIdentifier}.0003";
        public const string InvalidOffset = $"{Service.ServiceIdentifier}.0004";
    }
}
