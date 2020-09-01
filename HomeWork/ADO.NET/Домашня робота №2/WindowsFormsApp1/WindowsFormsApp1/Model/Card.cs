using System;

namespace WindowsFormsApp1.Model
{
    class Card
    {
        public int Id { get; set; }

        private string _fName;
        public string FName
        {
            get => _fName;
            set
            {
                if (string.IsNullOrEmpty(value.Trim(' ')))
                    throw new ApplicationException($"Name({value}) can't be empty!");
                _fName = value.Trim(' ');
            }
        }

        private decimal _moneyOnCard;
        public decimal MoneyOnCard
        {
            get => _moneyOnCard;
            set
            {
                if (value < 0)
                    throw new ApplicationException($"Money({value}) can't be less than zero.");
                _moneyOnCard = value;
            }
        }

        public override string ToString()
        {
            return $"Id = {Id}\nFName = {FName}\nMoneyOnCard = {MoneyOnCard}";
        }
    }
}