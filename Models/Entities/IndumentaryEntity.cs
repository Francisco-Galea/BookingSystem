using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking.Models.Entities;

namespace Boocking.Models.Entities
{
    public class IndumentaryEntity : RentableEntity
    {
        private int IndumentaryId;
        private string Size;
        private string Genre;

        public IndumentaryEntity(string NAME, string DESCRIPTION, decimal COSTUSAGERPERDAY, string SIZE, string GENRE) : base(NAME, DESCRIPTION, COSTUSAGERPERDAY)
        {
            Size = SIZE;
            Genre = GENRE;  
        }

        public int INDUMENTARYID
        {
            get { return IndumentaryId; }
            set { IndumentaryId = value; }
        }

        public string SIZE
        {
            get { return Size; }
            set { Size = value; }
        }

        public string GENRE
        {
            get { return Genre; }
            set { Genre = value; }
        }

    }
}
