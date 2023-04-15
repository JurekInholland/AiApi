namespace Models.Responses;

public class AnalysisResult
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string[] Results { get; set; }
}
