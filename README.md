# Aurora_Delivery_API Restful

### Layered Architecture

For this project, i utilized Domain Driven Design (DDD), a software modeling approach aimed at simplifying the implementation of business rules and complex processes by dividing responsibilities into layers.

### Overview of Layers

![image](https://github.com/carolineshimada/Aurora_Delivery_API/assets/71412867/9229e9b0-cfdf-4350-aef9-f59b8740911c)

### Application Layer
Responsible for the main development, this layer is where the API controllers and services are created. It receives all requests and forwards them to the appropriate service to perform the required action.
- **References:** Service and Domain layers.

### Domain Layer
This layer is responsible for implementing the classes/models that will be mapped to the database. It also contains interface declarations, constants, DTOs (Data Transfer Objects), and enums.

### Service Layer
Considered the "heart" of the project, this layer handles all business rules and validations before persisting data to the database.
- **References:** Domain, Infra.Data, and Infra.CrossCutting layers.

### Infrastructure Layer
Divided into two sub-layers:
- **Data:** Responsible for data persistence in the database, with or without an ORM.
- **Cross-Cutting:** This separate layer does not follow the hierarchy of the other layers. As the name suggests, it cuts across the entire hierarchy and contains functionalities that can be used throughout the code, such as CPF/CNPJ validation, external API consumption, and security implementation.
- **References:** Domain layer.

<img width="382" alt="image" src="https://github.com/carolineshimada/Aurora_Delivery_API/assets/71412867/831d0ae6-a116-4374-bb01-417dfc9977c1">



### Database

For this project, i used SQL Server. The "Scripts" folder contains the scripts used for database implementation.

### Project Planning and Status

The creation of the layers and the database configuration have been successfully completed. The project is currently in progress, with the next steps focusing on the development and integration of the API functionalities, as well as continuous testing and validation to ensure the quality and efficiency of the system.


| Day/Topic 1 | Status |
|----------|----------|
|  1 - Layers | Done |
|  2 - Database Connection | Done |
| 4 - Creating customers PUT, DELETE and GETbyId.  | In progress |
| 3 - Creating Order, OrderItems and Product crud. |     |
