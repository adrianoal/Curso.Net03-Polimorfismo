namespace PolimorfismoAula130.Entities
{
    class OutsoursedEmployee : Employee // O OutsoursedEmployee herda todas propriedades e metodos da classe Employee.
    {
        public double AdditionalCharge { get; set; }

        public OutsoursedEmployee()
        {
        }

        public OutsoursedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge; // 1.1 = 110%
        }


    }
}
