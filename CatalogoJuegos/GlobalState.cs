namespace CatalogoJuegos
{
    internal class GlobalState
    {
        // Instancia estática privada
        private static GlobalState _instance;

        /// <summary>
        /// Nombre del usuario actual.
        /// </summary>
        public string NombreUsuario { get; set; }

        /// <summary>
        /// Rol del usuario actual.
        /// </summary>
        public string RolUsuario { get; set; }

        /// <summary>
        /// Indica si el usuario actual está baneado.
        /// </summary>
        public bool UsuarioBaneado { get; set; }

        /// <summary>
        /// ID del usuario actual.
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Instancia del formulario Home.
        /// </summary>
        public Home HomeInstance { get; set; }

        // Constructor privado para evitar la creación de instancias fuera de la clase
        private GlobalState() { }

        /// <summary>
        /// Obtiene la única instancia de GlobalState.
        /// </summary>
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