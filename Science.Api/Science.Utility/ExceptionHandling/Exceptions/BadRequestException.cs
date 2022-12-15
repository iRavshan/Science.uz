namespace Science.Utility.ExceptionHandling.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string msg) : base(msg) {
        }
    }
}
