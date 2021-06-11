using System;


namespace DevFitness.API.Models.ViewModels
{
    public class UserViewModel
    {
        

        public  int Id { get; private set; }

        public string FullName { get; private set; }

        public decimal Height { get; private set; }

        public decimal Weight { get; private set; }

        public DateTime BirthDate { get; private set; }


        public UserViewModel(int id, string fullName, decimal height, decimal weight, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            Height = height;
            Weight = weight;
            BirthDate = birthDate;
        }

        public UserViewModel(int id, string fullName, decimal height, decimal weight)
        {
            Id = id;
            FullName = fullName;
            this.Height = height;
            Weight = weight;
        }
    }
}
