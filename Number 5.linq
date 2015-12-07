<Query Kind="Expression">
  <Connection>
    <ID>4be388c4-83c1-4c29-810b-b5a150c8d555</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WorkSchedule</Database>
  </Connection>
</Query>

from ES in EmployeeSkills
where ES.YearsOfExperience == (from E in EmployeeSkills
								select E.YearsOfExperience).Max()
select new
{
	Name = ES.Employee.LastName +  " " + ES.Employee.FirstName
}
