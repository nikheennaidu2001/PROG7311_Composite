using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//New controller created afterwards
namespace BurgerApi.Controllers{
    
    [ApiController]
    [Route("[controller]")]

public class CustomBurgerController: ControllerBase{       
      [HttpGet]
        public List<string> Get(bool tomato, bool cheese, 
        bool lettuce){

            IComponent burgerBun = new Bun();
             IComponent burgerPatty = new Patty();
              IComponent burgerLettuce = new Lettuce();
               IComponent burgerTomato = new Tomato();
                IComponent burgerCheese = new Cheese();

        //Creating an object for the Composite class
        Composite BaseBurger = new Composite();
        //For adding 
        BaseBurger.addBurgerParts(burgerBun);
        BaseBurger.addBurgerParts(burgerPatty);
        BaseBurger.addBurgerParts(burgerLettuce);
        BaseBurger.addBurgerParts(burgerTomato);
        BaseBurger.addBurgerParts(burgerCheese);

        //For removing
        if(!tomato)
           {
               
              BaseBurger.removeBurgerParts(burgerTomato);

           }

           if(!lettuce)
           {
               BaseBurger.removeBurgerParts(burgerLettuce);
           }

           if (!cheese)
           {
               BaseBurger.removeBurgerParts(burgerCheese);
           }

           List<string> returnList = new List<string>();
           returnList.Add(BaseBurger.getBurgerPart());

           return returnList;

       }
            
   }

}