
using System;

namespace PatientManagementSystem
{
    public static class PatientFactory
    {
        public static Patient CreatePatient(int type, string name)
        {
            return type switch
            {
                1 => new GeneralPatient(name),
                2 => new EmergencyPatient(name),
                3 => new VIPPatient(name),
                _ => throw new Exception("Invalid patient type")
            };
        }
    }
}
