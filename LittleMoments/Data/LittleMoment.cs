namespace LittleMoments.Data;

public class LittleMoment
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public required string Text { get; set; }

    public required int ChildId { get; set; }
    
    public Child? Child { get; set; }
}
