namespace Epam.TestAutomation.API.Models.ResponseModels.Bible
{
    public class AllBiblesModel
    {
        public Bibles[] data { get; set; }
    }

    public class Bibles
    {
        public string id { get; set; }
        public string dblId { get; set; }
        public string relatedDbl { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
        public string abbreviation { get; set; }
        public string abbreviationLocal { get; set; }
        public string description { get; set; }
        public string descriptionLocal { get; set; }
        public Language language { get; set; }
        public Country[] countries { get; set; }
        public string type { get; set; }
        public DateTime updatedAt { get; set; }
        public Audiobible[] audioBibles { get; set; }
    }

    public class Language
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
        public string script { get; set; }
        public string scriptDirection { get; set; }
    }

    public class Country
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
    }

    public class Audiobible
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameLocal { get; set; }
        public string dblId { get; set; }
    }
}
