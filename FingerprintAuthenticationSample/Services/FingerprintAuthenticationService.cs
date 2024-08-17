
using Plugin.Fingerprint.Abstractions;
using Plugin.Fingerprint;

namespace FingerprintAuthenticationSample.Services
{
    public class FingerprintAuthenticationService : IFingerprintAuthenticationService
    {
        public async Task<bool> AuthenticateAsync()
        {
            var result = await CrossFingerprint.Current.AuthenticateAsync(new AuthenticationRequestConfiguration("Authentication", "we need your fingerprint"));

            return result.Authenticated;
        }
    }
}
