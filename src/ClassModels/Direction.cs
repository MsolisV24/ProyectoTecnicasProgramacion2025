namespace ClassModels
{
    public class Direction
    {
        public int Id { get; set; }
        public string Province { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string OtherDetails { get; set; } = string.Empty;
        public bool IsPrincipal { get; set; } = false;
    }
}
