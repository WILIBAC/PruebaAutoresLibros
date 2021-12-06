namespace WebApiAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AutorId { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public int NumeroPaginas { get; set; }
        public Autor Autor { get; set; }
    }
}
