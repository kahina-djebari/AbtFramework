namespace AbtFramework
{
    public class Insight
    {
        string _author;
        string _title;
        public Insight()
        {

        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }
    }
}