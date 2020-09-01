using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Train : Transport
    {
        public string TrainClassification { get; set; }
        public int TrainNumber { get; set; }
        public Train(string trainClassification, int trainNumber, int regNumber) : base(regNumber)
        {
            TrainClassification = trainClassification;
            TrainNumber = trainNumber;
        }
        public override string Info()
        {
            return "Train\n" + $"Train classification: {TrainClassification}\n" +
                $"Train number: {TrainNumber}\n" +
                $"Registration number: {RegistrationNumber}\n";
        }
    }
}
