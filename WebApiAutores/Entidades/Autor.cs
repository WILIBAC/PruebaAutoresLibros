namespace WebApiAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string CiudadProcedencia { get; set; }
        public string Correo { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
