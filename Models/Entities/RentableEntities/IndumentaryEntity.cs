using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class IndumentaryEntity : RentableEntity
    {
        private int indumentaryId;
        private string? size;
        private string? genre;

        public IndumentaryEntity() : base () { }

        public int INDUMENTARYID
        {
            get { return indumentaryId; }
            set { this.indumentaryId = value; }
        }

        public string SIZE
        {
            get { return this.size; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El talle no puede estar vacío.");
                }
                this.size = value.Trim();
            }
        }

        public string GENRE
        {
            get { return this.genre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El genero no puede estar vacío.");
                }
                this.genre = value.Trim();
            }
        }

    }
}
