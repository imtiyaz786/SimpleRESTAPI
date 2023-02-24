# SimpleRESTAPI

This is a simple rest api built using asp.net core web api.

Rest API acts as an intermediary between client server.
Consider a scenario of restaurant where we have
- kitchen where foods/dishes are kept.
- Waiter who is the one responsible for getting food from the kitchen and delivering it to the guest.
- Guest is client who will have the food delivered to him.

Here, 
      
      - kitchen is backend/server/database
      
      - waiter is API
      
      - Guest is client.
      
 As a backend developer, normally you will be required to build REST APIs.
 After creating api, he needs to share it with client.
 Data through API will be consumed via client and the clients can be in any technology such as, MVC, angular, React, Java, etc.
 
 #### Middleware: oAuth, Cors, Routing, Swagger, etc.
- It comes by default but needs to be configured.
- It is not used or configured by default due to longer compilation, application getting heavier and thus, decreased performance.
- Use it and configure only when u need it.
  
### Steps:
The api controller "GreetingsController" has four GET action methods:

- Greetings() // returns greeting texts
- Greetings(string guestName)  // returns greeting to the guest.
- GetProducts() //returns list of products
- AddNumbers(int num1, int num2) // returns sum of two nums
 
 Each method is associated with [HttpGet] and [Route("route_name/{param1}/{param2}")] attribute.
 param1 and param2 are optional, we can use it as per the requirements.
 
 ### Note: Attribute routing is not enabled by default. We need to enable it by navigating to Startup.cs:
        
        - Add app.UseRouting() in configure method method of Startup class.
 
### Note: Swagger comes bydefault in the newer version of dotnet core.
        
        - we need to ensure open api support option is checked. In case of older version, we can set it up in Startup.cs class.
        

 
