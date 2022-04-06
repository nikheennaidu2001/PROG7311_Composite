using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

//Interface created first
namespace BurgerApi{
       public interface IComponent{
//returns different parts of the composite
     string getBurgerPart();

    }
}