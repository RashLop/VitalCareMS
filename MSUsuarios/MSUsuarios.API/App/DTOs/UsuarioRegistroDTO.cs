using System.Text.Json.Serialization;

namespace MSUsuarios.App.DTOs
{
    public class UsuarioRegistroDto
    {
        public string Nombres { get; set; } = string.Empty;
        public string ApellidoPaterno { get; set; } = string.Empty;
        public string? ApellidoMaterno { get; set; }
        public string Ci { get; set; } = string.Empty;
        public string? CiExtencion { get; set; }
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string? Role { get; set; } = string.Empty;    

        [JsonIgnore]
        public string UserName { get; set; } = string.Empty;

        [JsonIgnore]
        public string Password { get; set; } = string.Empty;
    }
}
