using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "20", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand", "General medicine");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "45", "986782343", "5555-555-555", DateTime.Now, "Queen Street", "Pepe", "General medicine");
            Console.WriteLine(appointmentResult2);
        }
    }
}
