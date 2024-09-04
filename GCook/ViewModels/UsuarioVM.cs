namespace GCook.ViewModels;

    public class UsuarioVM
    {
        public string UsuarioID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }
        public string Perfil { get; set; }
        public bool IsAdmin { get; set; }
        
    }
