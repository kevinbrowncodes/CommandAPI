select * from "CommandItems"

/* (Jackson 150)
insert into "CommandItems" ("HowTo", "Platform", "CommandLine")
values ('Create an EF migration', 'Entity Framework Core Command Line',
'dotnet ef migrations add');

insert into "CommandItems" ("HowTo", "Platform", "CommandLine")
values ('Apply Migrations to DB', 'Entity Framework Core Command Line',
'dotnet ef database update');
*/

/* (Jackson 152) 
insert into "CommandItems" ("HowTo", "Platform", "CommandLine")
values ('Create an EF migration', 'Entity Framework Package Manager Console',
'add-migration <name of migration>');

insert into "CommandItems" ("HowTo", "Platform", "CommandLine")
values ('Apply Migrations to DB', 'Entity Framework Package Manager Console',
'update database');
*/

update "CommandItems" 
set Platform = "Entity Framework Package Manager Console"
where Platform = "Entity Framework Manager Console"

/* Source */
-- Jackson 150 