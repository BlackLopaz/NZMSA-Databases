# NZMSA-Databases

![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1843).png)
![Address Table Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1844).png)
![Student Table Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1845).png)

Notes: After many many hours of trying, the API method that changes the address of a student using his/her StudentId errors due to multiple endpoints and I could not find a solution. However the rest do work and both of the PUT method works if there is only one.

![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1846).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1847).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1848).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1849).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1850).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1851).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1852).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1853).png)
![Swagger UI Screenshot](https://github.com/BlackLopaz/NZMSA-Databases/blob/master/NZMSA-Images/Screenshot%20(1854).png)

I decided to not make anything Required in the Address table as everything would be required if an address is being input, otherwise there would be no point in inputting anything. The user may also only want to share partial information such as their city or suburb rather than their full address.

I also decided to make Street Number a string due to apartments, sublets etc where the address number isn't just a number. E.g. "12A" or "Floor 12 room 2"

Azure Database:
https://portal.azure.com/#@UOA.onmicrosoft.com/resource/subscriptions/46bb0964-8674-4d46-a85a-856cc7cb0a82/resourceGroups/MSA_mkmu260/providers/Microsoft.Sql/servers/nzmsa-mkmu260-server/databases/NZMSA_mkmu260_Databases/overview

https://portal.azure.com/#@UOA.onmicrosoft.com/resource/subscriptions/46bb0964-8674-4d46-a85a-856cc7cb0a82/resourceGroups/MSA_mkmu260/providers/Microsoft.Sql/servers/nzmsa-mkmu260-server/overview

http://msa-mkmu260-databases.azurewebsites.net
