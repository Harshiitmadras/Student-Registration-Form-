
using System;

namespace PatientManagementSystem
{
    public static class NotificationService
    {
        public static void NotifyDepartments(string patientName)
        {
            Console.WriteLine($"[EVENT] Billing generated for patient: {patientName}");
            Console.WriteLine("Notifying Accounts Department...");
            Console.WriteLine("Notifying Medical Records...");
        }
    }
}
