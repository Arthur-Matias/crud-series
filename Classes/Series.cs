namespace DIO.CrudSeries
{
    public class Series : BaseEntity
    {
        public Genre Genre { get; private set; }

        public string Title { get; private set; }

        public string Description { get; private set; }

        private int Year { get; set; }
        public bool isDeleted { get; private set; }

        public Series(int _id, Genre _genre, string _title, string _description, int _year){
            this.Id = _id;
            this.Genre = _genre;
            this.Title = _title;
            this.Description = _description;
            this.Year = Year;
            this.isDeleted = false;
        }

        public override string ToString()
        {
            string value = "";
            value += $"Genre: {this.Genre} \n";
            value += $"Title: {this.Title} \n";
            value += $"Description: {this.Description} \n";
            value += $"Year: {this.Year} \n";
            value += $"Deleted: {this.isDeleted} \n";

            return value;
        }
        public void Delete(){
            this.isDeleted = true;
        }
    }
}