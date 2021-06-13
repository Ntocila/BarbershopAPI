## Introduction

This BackEnd Service is made for a barbershop. After contacting the client, we came in an agreement about what the requirements for this project will be and what his requirements for this application are. In this repository I explain only how the Barbershop Service part works and how it is constructed. 


### Client's Requirements
The client required that he can:

1. View Appointments
2. Create Appointments
3. Edit Appointments
4. Delete Appointments
5. View Customer Details

To achieve that we need a full stack project which includes a Back-End, Front-End and a Database.
This Repository covers the Back-End part of the project.
<br/>

### Project Construction

Below I include diagrams to give you an idea of how this project exactly works.
The first part of the applciation is the authentication. Before accessing the application, the user has to authenticate himself by loggin in. Credentials will get compared to the ones in the database and if credentials are correct then the user will navigate to homepage.

![authenticationdiagram](https://user-images.githubusercontent.com/55668398/121593855-a4671680-ca3c-11eb-871a-3946027ca3fb.JPG)


The back-end service includes all the models-controllers-views necessary to achieve the above requirements. To retrieve and display all the information from the Back-End there is a Front-End necessary. We will talk about the front-end later on one of my other repositories. Finally, 
to access all the data that are stored in our Database we have to make HTTP requests. The diagram below explains how the HTTP requests work according to user's actions.

![diagram](https://user-images.githubusercontent.com/55668398/121595285-6965e280-ca3e-11eb-91b3-2f0fc6ed0e73.JPG)


