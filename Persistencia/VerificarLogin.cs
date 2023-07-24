    using System;
    namespace proyecto.Persistencia
{
        public class PersistenceLayer
        {
            // Aquí implementarás métodos para interactuar con la base de datos,
            // como verificar las credenciales del usuario, entre otros.
            // Por simplicidad, simularemos el proceso de inicio de sesión con
            // datos predefinidos.
            public bool VerifyLogin(string username, string password)
            {
                // Simulamos una verificación válida.
                return username == "usuario" && password == "contraseña";
            }
        }
    }


