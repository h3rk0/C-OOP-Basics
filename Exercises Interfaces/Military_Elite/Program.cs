using System;
using System.Collections.Generic;
using System.Linq;

namespace Military_Elite
{
    class Program
    {
        static void Main(string[] args)
        {
			List<ISoldier> soldiers = new List<ISoldier>();

            while(true)
			{
				try
				{
					string input = Console.ReadLine();

					if (input == "End")
					{
						break;
					}

					string[] inputArgs = input.Split();

					if (InvalidInput(inputArgs[0]))
					{
						continue;
					}

					string id = inputArgs[1];
					string firstName = inputArgs[2];
					string secondName = inputArgs[3];
					double salary = double.Parse(inputArgs[4]);
					
					

					ISoldier soldier;

					if (inputArgs[0] == "Private")
					{
						soldier = new Private(id, firstName, secondName, salary);
					}
					else if (inputArgs[0] == "LeutenantGeneral")
					{
						var leutenant = new LeutantGeneral(id, firstName, secondName, salary);

						for (int inputIndex = 5; inputIndex < inputArgs.Length; inputIndex++)
						{
							ISoldier hired = soldiers.First(s => s.Id == inputArgs[inputIndex]);
							leutenant.AddPrivate(hired);
							//((ILeutantGeneral) soldier).AddPrivate
						}

						soldier = leutenant;
					}
					else if (inputArgs[0] == "Engineer")
					{
						//corps[5] , [6] pairs [7] 
						var engineer = new Engineer(id, firstName, secondName, salary);
						string corps = inputArgs[5];
						engineer.ParseCorps(corps);

						for (int repairPairIndex = 6; repairPairIndex < inputArgs.Length; repairPairIndex += 2)
						{
							string repairName = inputArgs[repairPairIndex];
							int repairHours = int.Parse(inputArgs[repairPairIndex + 1]);

							IRepair repair = new Repair(repairName, repairHours);
							engineer.AddRepair(repair);
						}

						soldier = engineer;

					}
					else if (inputArgs[0] == "Commando")
					{
						var commando = new Commando(id, firstName, secondName, salary);

						string corps = inputArgs[5];
						commando.ParseCorps(corps);

						for (int missionIndex = 6; missionIndex < inputArgs.Length; missionIndex += 2)
						{
							string missionName = inputArgs[missionIndex];
							string missionState = inputArgs[missionIndex + 1];

							try
							{
								IMission mission = new Mission(missionName, missionState);
								commando.AddMission(mission);
							}
							catch (Exception e)
							{

								//Console.WriteLine(e.Message);
							}

						}

						soldier = commando;
					}
					else
					{
						soldier = new Spy(id, firstName, secondName, int.Parse(inputArgs[4]));
					}

					soldiers.Add(soldier);
				}
				catch (Exception e)
				{
					//Console.WriteLine(e.Message);
				}
				
			}

			foreach (var soldier in soldiers)
			{
				Console.WriteLine(soldier);
			}
        }

		private static bool InvalidInput(string input)
		{
			return input != "Private" && input != "LeutenantGeneral"
				&& input != "Engineer" && input != "Commando" && input != "Spy";
		}
	}
}
