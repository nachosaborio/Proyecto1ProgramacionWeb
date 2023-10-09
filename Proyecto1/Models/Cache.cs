namespace Proyecto1.Models
{
    public static class Cache
    {
        private static List<Empleado> empleados = new List<Empleado>();
        private static List<Parqueo> parqueos = new List<Parqueo>();
        private static List<Tiquete> tiquetes = new List<Tiquete>();

        #region Empleados
        public static void AddEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public static List<Empleado> GetAllEmpleados()
        {
            return empleados;
        }

        public static Empleado GetEmpleadoXId(int ID)
        {
            return empleados.Find(x => x.Id == ID);
        }

        public static void UpdateEmpleado(Empleado empleado)
        {
            empleados.Remove(empleados.Find(x => x.Id == empleado.Id));
            empleados.Add(empleado);
        }

        public static void DeleteEmpleado(int ID)
        {
            empleados.Remove(empleados.Find(x => x.Id == ID));
        }
        #endregion

    }
}
