namespace HomeWork5.Prototype.Implementations
{
    public class IdInfo
    {
        public string Type {  get; set; }
        public int IdNumber { get; set; }

        public IdInfo(int idNumber, string type)
        {
            IdNumber = idNumber;
            Type = type;
        }
    }
}
