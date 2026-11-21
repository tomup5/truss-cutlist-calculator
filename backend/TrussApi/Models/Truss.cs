namespace TrussApi.Models;

public class Truss
{
    
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double SpanFeet { get; set; }
    public double PitchRisePer12 { get; set; }
    public double OverhangInches { get; set; }
    public int Quantity { get; set; }

}