namespace BehsaMatchApi.Model
{
    public class Fields
    {
        public string Class { get; set; }
        public string TestField { get; set; }
    }

    public class Entry
    {
        public int RecordId { get; set; }
        public string CreatedBy { get; set; }
        public long Created { get; set; }
        public string Id { get; set; }
        public Fields Fields { get; set; }
        public string OwnedBy { get; set; }
    }

    public class List
    {
        public List<Entry> Entry { get; set; }
    }

    public class GeneralResponse
    {
        public int Total { get; set; }
        public List List { get; set; }
    }
}
