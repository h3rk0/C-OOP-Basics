using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
			Dictionary<string, Doctor> doctors = new Dictionary<string, Doctor>();
			Dictionary<string, Department> departments = new Dictionary<string, Department>();
			Dictionary<string, Pacient> pacients = new Dictionary<string, Pacient>();


            string command = Console.ReadLine();
            while (command != "Output")
            {
				// arguments
                string[] args = command.Split();

				// department
				string departmentString = args[0];
				Department department = departments.SingleOrDefault(d => d.Key == departmentString).Value;

				if (department == null) 
				{
					department = new Department(departmentString);
					departments.Add(departmentString, department);
				}

				// doctor
				string firstName = args[1];
				string secondName = args[2];
				string doctorName = $"{firstName} {secondName}";
				Doctor doctor = doctors.SingleOrDefault(doc => doc.Key == doctorName).Value;

				if(doctor == null)
				{
					doctor = new Doctor(doctorName);
					doctors.Add(doctorName, doctor);
				}

				string pacientName = args[3];
				Pacient pacient = pacients.SingleOrDefault(p => p.Key == pacientName).Value;

				if(pacient == null)
				{
					pacient = new Pacient(pacientName);
					pacients.Add(pacientName,pacient);
				}

				
				if(department.AddPacient(pacient))
				{
					doctor.AddPacient(pacient);
				}
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

				// initialize but not set
				Department department;
				Doctor doctor;

				if (args.Length == 1)
				{
					string departmentString = args[0];
					department = departments.SingleOrDefault(d => d.Key == departmentString).Value;

					department.PrintPacients();
					
				}
				else
				{
					string firstArgument = args[0];

					if(departments.ContainsKey(firstArgument))
					{
						string departmentString = args[0];
						int room = int.Parse(args[1]);

						department = departments.SingleOrDefault(d => d.Key == departmentString).Value;
						department.PrintPacientsInRoom(room);
					}
					else // case : doctor 
					{
						string doctorName = $"{args[0]} {args[1]}";
						doctor = doctors.SingleOrDefault(d => d.Key == doctorName).Value;

						doctor.PrintPacients();
					}
				}
                
                command = Console.ReadLine();
            }
        }
    }
}
