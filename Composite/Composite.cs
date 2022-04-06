using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApi{

//Created this seventh
//This were you build stuff
public class Composite : IComponent{
     List<IComponent> components = new List<IComponent>();

      //Add method to component list
      public void addBurgerParts(IComponent component){
         components.Add(component);
      }
      //Remove method from component list
     public void removeBurgerParts(IComponent component){
         components.Remove(component);
      }


    //Loops the array and gets the individual parts
     public string getBurgerPart()
    {
          string part = null;

          for(int i=0; i < components.Count; i++)
          {
           
            part += components.ElementAt(i).getBurgerPart();

          }
          
          return part;
   }

  
      
}


}