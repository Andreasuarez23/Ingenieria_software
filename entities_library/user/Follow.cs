namespace entities_library.user;
public class Follow
{
    public long Id { get; set; } // Id de relación de seguimiento

    public long FollowerId { get; set; } // Id del usuario que sigue a otro

    public long FollowingId { get; set; } // Id del usuario que esta siendo seguido

   
}
