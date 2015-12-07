<Query Kind="Program">
  <Connection>
    <ID>4be388c4-83c1-4c29-810b-b5a150c8d555</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

void Main()
{
	var results = from Sk in Skills
				where Sk.RequiresTicket == true
				orderby Sk.Description
				select new
				{
					Description = Sk.Description,
					Employee = from ESk in EmployeeSkills
								where ESk.SkillID == Sk.SkillID
								select new
					{
						Name = ESk.Employee.LastName + " " + ESk.Employee.FirstName,
						Level = ESk.Level,
						YearsOfExperience = ESk.YearsOfExperience
					}
					
					
				};
				results.Dump();
}

//public class SkillEmployees
//{
	//public string Description {get; set;}
	//public string Name {get; set;}
	//public int Level {get; set;}
	//public int? YearsOfExperience {get; set;}
//}
// Define other methods and classes here
