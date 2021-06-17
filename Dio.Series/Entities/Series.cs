using Dio.Series.Entities.Enumerators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Entities
{
    public class Series : BaseEntity
    {
        public Series()
        {
        }

        public Series(int id,string title, string description, EnumGenre genre, int rate, int seasons, int release)
        {
            Id = id;
            Title = title;
            Description = description;
            Genre = genre;
            Rate = rate;
            Seasons = seasons;
            Release = release;
        }

        private string Title { get; set; }
        private string Description { get; set; }
        private EnumGenre Genre { get; set; }
        private int Rate { get; set; }
        private int Seasons { get; set; }
        private int Release { get; set; }

        public string GetTitle()
        {
            return Title;
        }

        public int GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return $"Titlte: {Title}" + Environment.NewLine
                 + $"Genre: {Genre}" + Environment.NewLine
                 + $"Description: {Description}" + Environment.NewLine
                 + $"Rate: {Rate}" + Environment.NewLine
                 + $"Amount of seasons: {Seasons}" + Environment.NewLine
                 + $"Year: {Release}";
        }
    }
}
