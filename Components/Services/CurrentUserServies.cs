using Microsoft.AspNetCore.Components;


namespace Project.Components.Services
{
    public class CurrentUserServies
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public string full_name { get; set; }
        public bool IsLoggedIn { get; set; } = false;
        public bool IsStudentExist { get; set; } = false;
        public bool IsFacultyExist { get; set; } = false;
        public void Logout()
        {
            Email = null;
        }



    }

    // ❌ Problem: This method is outside the class

}
