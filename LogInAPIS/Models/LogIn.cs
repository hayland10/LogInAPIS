using System.ComponentModel;

namespace LogInAPIS.Models
{
    public class LogIn
    {
        public string Id { get; set; }
        public string Usuario { get; set; }
        [PasswordPropertyText]
        public string Contraseña { get; set; }
        public string Categoria { get; set; }
    }
}
