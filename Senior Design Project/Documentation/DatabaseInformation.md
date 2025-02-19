# Database Software

For our database, we decided to use MySql. We chose MySql because computation wise, it requires very little to run compared to other options that we found. So, it is a program that we can have constantly run on our OpenStack server with little risk of it taking too much processing power. 

# Other Options

We were originally going to use MongoDB, since it interacted perfectly with Spring Boot, which is our choice for server software. However, it took too much processing power to keep constantly running on our OpenStack server, so we had to come up with a new option which was MySql

# General Database Schema

Our database included 10 different entries for the Employee table and they were:

EmployeeID
FirstName
LastName
Email
Phone
Address
HireDate
DepartmentID
Position
MaxWeeklyHours
PreferredShiftPattern

Link: [Database Repository Link](https://gitlab.csi.miamioh.edu/2023-spring-fall-capstone-projects/sam-adams-team-braun/sa-team-braun/-/blob/master/res/SchedulingApp.sql)