# BarbershopAPI

#### This BackEnd Service is made for a barbershop store. The client required that he can:

1. View Appointments
2. Create Appointments
3. Edit Appointments
4. Delete Appointments
5. View Customer Details

#### Below I include diagrams to give you an idea of how this project exactly works.

The first part of the applciation is the authentication. Before accessing the application, the user has to authenticate himself by loggin in. Credentials will get compared to the ones in the database and if credentials are correct then the user will navigate to homepage.

![authenticationdiagram](https://user-images.githubusercontent.com/55668398/121593855-a4671680-ca3c-11eb-871a-3946027ca3fb.JPG)


The back-end service includes all the models-controllers-views necessary to achieve the above requirements. To retrieve or display all the information from the back-end there is a front-end necessary. We will talk about the front-end later on one of my other repositories. Finally, 
to access all the data we have to make HTTP requests. The diagram below explains how the HTTP requests work according to user's actions.

![diagram](https://user-images.githubusercontent.com/55668398/121595285-6965e280-ca3e-11eb-91b3-2f0fc6ed0e73.JPG)
