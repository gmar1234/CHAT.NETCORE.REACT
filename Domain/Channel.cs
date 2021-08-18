using System;

namespace Domain
{
    public class Channel
    {
        // Single la llave primaria no tiene el nombre de Id se coloca [Key] 
        // Ppara indicar que es primaria
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
