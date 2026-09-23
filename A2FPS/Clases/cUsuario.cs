namespace A2FPS
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string PasswordHash { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }

        public Usuario()
        {
            NombreUsuario = string.Empty;
            PasswordHash = string.Empty;
            Rol = string.Empty;
        }

        public Usuario(int idUsuario, string nombreUsuario, string passwordHash, string rol, bool estado)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            PasswordHash = passwordHash;
            Rol = rol;
            Estado = estado;
        }
    }
}