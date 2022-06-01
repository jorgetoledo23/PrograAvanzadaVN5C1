namespace SistemaWeb.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Rol { get; set; } // Administrador , GestionStock , 
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        
    }
}