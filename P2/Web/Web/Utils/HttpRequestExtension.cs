using UtilsApp.DTOs;

namespace UtilsApp.Utils
{
    public static class HttpRequestExtension
    {
        public static UserDTO getCookieUser(this HttpRequest Request)
        {
            int userId = string.IsNullOrWhiteSpace(Request.Cookies["UserId"]) ? 0 : int.Parse(Request.Cookies["UserId"]);
            string userName = Request.Cookies["UserName"] ?? "";

            return new UserDTO() { Name = userName, Id = userId };
        }
    }
}
