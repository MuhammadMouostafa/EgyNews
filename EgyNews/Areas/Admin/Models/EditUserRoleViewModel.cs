namespace EgyNews.Areas.Admin.Models
{
    public class EditUserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string SelectedRole { get; set; }
        public List<string> Roles { get; set; } = new List<string>();
    }
}
