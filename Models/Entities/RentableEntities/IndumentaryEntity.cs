using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models.Entities;

namespace Boocking.Models.Entities.RentableEntities
{
    public class IndumentaryEntity : RentableEntity
    {
        private int indumentaryId;
        private string size;
        private string genre;

        public IndumentaryEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string SIZE, string GENRE) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            this.size = SIZE;
            this.genre = GENRE;
        }

        public int INDUMENTARYID
        {
            get { return indumentaryId; }
            set { this.indumentaryId = value; }
        }

        public string SIZE
        {
            get { return size; }
            set { this.size = value; }
        }

        public string GENRE
        {
            get { return genre; }
            set { this.genre = value; }
        }

    }
}
