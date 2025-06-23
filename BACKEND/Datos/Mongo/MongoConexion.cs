namespace BACKEND.Datos.Mongo
{
    public class MongoConexion
    {
        public string ConnectionString { get; set; } = "mongodb://localhost:27017";
        public string DatabaseName { get; set; } = "Biblioteca";
        public string CollectionName { get; set; } = "Libro";
    }
}