using UtilsApp.DTOs;

namespace UtilsApp.Utils
{
    public static class HttpResponseExtension
    {
        private static CookieOptions userCookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddDays(1),
            HttpOnly = true
        };

        public static void toSaveCookieUser(this HttpResponse Respose, UserDTO user)
        {
            Respose.Cookies.Append("UserId", user.Id.ToString(), userCookieOptions);
            Respose.Cookies.Append("Username", user.Name, userCookieOptions);
        }

        public static void toClearCookieUser(this HttpResponse Response)
        {
            Response.Cookies.Append("UserId", "", userCookieOptions);
            Response.Cookies.Append("Username", "", userCookieOptions);
        }
    }
}
