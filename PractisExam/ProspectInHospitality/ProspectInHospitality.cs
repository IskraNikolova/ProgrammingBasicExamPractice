using System;

namespace ProspectInHospitality
{
    public class ProspectInHospitality
    {
        public static void Main()
        {
            decimal builders = decimal.Parse(Console.ReadLine());
            decimal buildersAvarageSalary = builders * 1500.04m;

            decimal receptionists = decimal.Parse(Console.ReadLine());
            decimal receptionistsAvarageSalary = receptionists * 2102.10m;

            decimal chambermaids = decimal.Parse(Console.ReadLine());
            decimal chambermaidsAvarageSalary = chambermaids * 1465.46m;

            decimal technicians = decimal.Parse(Console.ReadLine());
            decimal techniciansAvarageSalary = technicians * 2053.33m;

            decimal otherStaffMemberss = decimal.Parse(Console.ReadLine());
            decimal otherStaffMemberssAvarageSalary = otherStaffMemberss * 3010.98m;

            decimal NikiSalary = decimal.Parse(Console.ReadLine());
            decimal USACurrencyRate = decimal.Parse(Console.ReadLine());
            decimal NikiSalaryInLeva = NikiSalary * USACurrencyRate;

            decimal yourSalary = decimal.Parse(Console.ReadLine());

            decimal amount = buildersAvarageSalary +
                  receptionistsAvarageSalary +
                  chambermaidsAvarageSalary +
                  techniciansAvarageSalary +
                  otherStaffMemberssAvarageSalary +
                  NikiSalaryInLeva + yourSalary;

            Console.WriteLine($"The amount is: {amount:F2} lv.");

            decimal budget = decimal.Parse(Console.ReadLine());
            decimal left = budget - amount;
            if (left >= 0)
            {
                Console.WriteLine($"YES \\ Left: {left:F2} lv.");
            }
            else
            {
                decimal diff = Math.Abs(left);
                Console.WriteLine($"NO \\ Need more: {diff:F2} lv.");
            }
        }
    }
}
