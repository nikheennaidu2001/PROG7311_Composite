using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi{

//Created this fifth
public class Tomato : IComponent{

    public string getBurgerPart(){
          return "Tomato";
      }

}


}