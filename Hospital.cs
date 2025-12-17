
using System;

namespace PatientManagementSystem
{
    public class Hospital
    {
        public void Start()
        {
            Console.WriteLine("=== Patient Management System ===");
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Select Patient Type:");
            Console.WriteLine("1. General");
            Console.WriteLine("2. Emergency");
            Console.WriteLine("3. VIP");
            int choice = int.Parse(Console.ReadLine());

            Patient patient = PatientFactory.CreatePatient(choice, name);

            Billing billing = new Billing();
            billing.OnBillGenerated += NotificationService.NotifyDepartments;

            double amount = billing.CalculateBill(patient);
            Console.WriteLine($"Final Bill Amount: ₹{amount}");
        }
    }
}
