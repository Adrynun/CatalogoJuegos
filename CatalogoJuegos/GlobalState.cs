namespace CatalogoJuegos
{
    internal class GlobalState
    {
        // Instancia estática privada
        private static GlobalState _instance;

        // Propiedades
        public string NombreUsuario { get; set; }
        public string RolUsuario { get; set; }
        public bool UsuarioBaneado { get; set; }

        // Nueva propiedad para la instancia de Home
        public Home HomeInstance { get; set; }

        // Constructor privado para evitar la creación de instancias fuera de la clase
        private GlobalState() { }

        // Propiedad pública para obtener la única instancia de GlobalState
        public static GlobalState Instance
        {
            get
            {
                // Si la instancia no ha sido creada, la creamos
                if (_instance == null)
                {
                    _instance = new GlobalState();
                }
                return _instance;
            }
        }
    }
}
