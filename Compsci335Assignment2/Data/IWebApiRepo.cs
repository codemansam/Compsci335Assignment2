﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compsci335Assignment2.Models;

namespace Compsci335Assignment2.Data

// Endpoint 1: Going to need to register user using POST  - name this api Register
// deal with a UserName that has already been registered with "Username not available."
// Return status code "200 OK" Response message "User successfully registered."
//The “Ok” method will set the status code of the HTTP response to 200. In order to show a return message, e.g.,
//“User successfully registered.”, you can pass the return message as a parameter to the “Ok” method, e.g., Ok(“User successfully registered.”).


// Endpoint 2: Get the version of the Web api.  This endpoint can only be accessed by registered users
// Authentication is carried out when this endpoint is called.  Basic Authentication
// Name this API as GetVersionA

// Endpoint 3: PurchaseItem
// user should specify ProductId and Quantity and must be registered user.
// If valid the purchase should be recorded in the Orders table


//Endpoint 4: Purchase a single item. 
// Name this APi PurchaseSingleItem
// specify a ProductID.  This one has Quantity set to 1 by default.
// Implement using Get method

{
    public interface IWebApiRepo
    {
        User Register(User user);
    }
}
 