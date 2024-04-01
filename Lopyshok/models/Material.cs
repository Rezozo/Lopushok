namespace Lopyshok.models
{
    public class Material
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CountInPack { get; set; }
        public string Unit { get; set; } 
        public double CountInStock { get; set; }
        public double MinCount { get; set; }
        public decimal Cost { get; set; }   
        public string MaterialTypeTitle { get; set; }
        public double CountInCurrentProduct { get; set; }  

        public Material() { }
    }
}
