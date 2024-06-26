using System.ComponentModel.DataAnnotations.Schema;

namespace Lista_de_Tarefas.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public string Token { get; set; }

        [NotMapped]
        public string PasswordString { get; set; } = string.Empty;
        public List<TaskModel> Tasks { get; set; } = new List<TaskModel>();
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
