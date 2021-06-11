using System;

namespace DevFitness.API.Core.Entities
{
    public class Meal : BaseEntity
    {
        protected Meal()
        {

        }

        public string Description { get; private set; }
        public int Calories { get; private set; }
        public DateTime Date { get; private set; }

        public int UserId { get;  set; }

        public Meal(string description, int calories, DateTime date, int userId ) : base()
        {
            Description = description;
            Calories = calories;
            Date = date;
            UserId = userId;
        }

        public void Update(string description, int calories, DateTime date)
        {
            Description = description;
            Calories = calories;
            Date = date;
        }

        internal void Update(string description, int calories, object date)
        {
            throw new NotImplementedException();
        }
    }
}
