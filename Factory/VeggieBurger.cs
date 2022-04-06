using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi{
public class VeggieBurger : IBurger{

public string getBun(){
    return "riceflour";
}

public string getPatty(){
    return "Ultimate patty";
}

}

}