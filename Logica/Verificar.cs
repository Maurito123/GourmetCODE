using proyecto.Persistencia;
using proyecto.Persistencia;

namespace TuProyecto.Logica
{
    public class LogicLayer
    {
        private PersistenceLayer persistenceLayer;

        public LogicLayer()
        {
            persistenceLayer = new PersistenceLayer();
        }

        public bool VerifyLogin(string username, string password)
        {
            // Aquí puedes agregar lógica adicional antes de verificar el inicio de sesión.
            // Por ejemplo, verificar si los campos no están vacíos, validar el formato, etc.
            return persistenceLayer.VerifyLogin(username, password);
        }
    }
}