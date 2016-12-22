namespace Graph
{
    public class PersonPoco
    {
        public string ID { get; private set; }
        public bool IsMale { get; private set; }

        public PersonPoco(string id, bool isMale)
        {
            ID = id;
            IsMale = isMale;
        }

        public override string ToString()
        {
            return $"{ID}-{IsMale}";
        }
    }
}