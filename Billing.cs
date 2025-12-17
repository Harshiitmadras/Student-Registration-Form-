
using System;

namespace PatientManagementSystem
{
    public delegate double BillingStrategy(double baseAmount);

    public class Billing
    {
        public event Action<string> OnBillGenerated;

        public double CalculateBill(Patient patient)
        {
            BillingStrategy strategy = patient switch
            {
                GeneralPatient => amount => amount,
                EmergencyPatient => amount => amount * 1.5,
                VIPPatient => amount => amount * 2,
                _ => amount => amount
            };

            double finalAmount = strategy(patient.BaseCharge);
            OnBillGenerated?.Invoke(patient.Name);
            return finalAmount;
        }
    }
}
