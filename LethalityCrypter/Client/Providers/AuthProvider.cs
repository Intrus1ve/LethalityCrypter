using Firebase.Auth;
using System.Threading.Tasks;

namespace LethalityCrypter.Client.Providers
{
    public class AuthProvider
    {
        public static FirebaseAuthProvider Auth = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyD7rZy9v0XuFU5nDzyR2y3x3E5IsUTLR7s"));

        public static User CurrentUser = null;

        public static async Task<string> LoginAsync(string mail, string password)
        {
            try
            {
                var signIn = await Auth.SignInWithEmailAndPasswordAsync(mail, password);
                await signIn.RefreshUserDetails();

                if (signIn.User.IsEmailVerified)
                {
                    CurrentUser = signIn.User;
                    return signIn.User.LocalId;
                }
                else
                {
                    return "Please verify your mail.";
                }
            }
            catch (FirebaseAuthException ex)
            {
                return ex.Reason.ToString();
            }
        }

        public static async Task<string> RegisterAsync(string mail, string password, string displayName)
        {
            try
            {
                var signUp = await Auth.CreateUserWithEmailAndPasswordAsync(mail, password, displayName, true);

                return "You registered. Please verify your mail and login.";
            }
            catch (FirebaseAuthException ex)
            {
                return ex.Reason.ToString();
            }
        }
    }
}
