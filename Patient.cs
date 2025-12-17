
namespace PatientManagementSystem
{
    public abstract class Patient
    {
        public string Name { get; set; }
        public abstract double BaseCharge { get; }

        protected Patient(string name)
        {
            Name = name;
        }
    }

    public class GeneralPatient : Patient
    {
        public GeneralPatient(string name) : base(name) { }
        public override double BaseCharge => 2000;
    }

    public class EmergencyPatient : Patient
    {
        public EmergencyPatient(string name) : base(name) { }
        public override double BaseCharge => 5000;
    }

    public class VIPPatient : Patient
    {
        public VIPPatient(string name) : base(name) { }
        public override double BaseCharge => 10000;
    }
}
