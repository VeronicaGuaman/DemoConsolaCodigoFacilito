namespace DemoConsolaCodigoFacilito
{
    //Nueva funcionalidad C# 12, Principal Constructor
    public class PersonPrincipalControler(int id, string name, string description)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set;}= description;
    }
}
