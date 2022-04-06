using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi{
    
    //Created this sixth
    public class Cheese : IComponent{

      public string getBurgerPart(){
          return "Cheese";
      }

    }
}