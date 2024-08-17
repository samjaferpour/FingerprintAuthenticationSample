namespace FingerprintAuthenticationSample.Services
{
    public interface IFingerprintAuthenticationService
    {
        Task<bool> AuthenticateAsync();
    }
}
