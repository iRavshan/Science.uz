namespace Science.API.Helpers.IServices
{
    public interface IJwtManager
    {
        string CreateToken();
        RefreshToken GenerateRefreshToken();
        RefreshToken GetRefreshToken();
        void SetRefreshToken(RefreshToken newRefreshToken);
    }
}
