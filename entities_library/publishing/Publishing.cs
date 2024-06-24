namespace entities_library.publishing;

public class Publishing
{
    public int Id { get; set; } // Id de la publicación 
    
    public int IdUser { get; set; } // Id del usuario que publicó
    
    public string Description { get; set; }// Descripción de la publicación
    
    public byte[] Content { get; set; } // Contenido de la publicación 
   
    public DateTime PublishDate { get; set; } // Fecha de publicación 
    
    public PublishStatus Status { get; set; } // Estado de la publicación 
}
