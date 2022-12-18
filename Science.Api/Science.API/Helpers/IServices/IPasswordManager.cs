namespace Science.API.Helpers.IServices
{
    public interface IPasswordManager
    {
        byte[] CreatePasswordHash(string password);
        byte[] CreatePasswordSalt(string password);
        bool VerifyPasswordHash(string password);
    }
}
