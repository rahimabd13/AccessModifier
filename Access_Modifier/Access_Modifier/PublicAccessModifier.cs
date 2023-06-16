using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    //Access Modifiers Are The Keybords Which Specfies The Accessbility or Scope of a Variable or a Function
    //It Will Control Visility of a Class
    public class PublicAccessModifier
    {
        //public modifier allow a part of a program in the same assembly or a different assembly to access the type and members

        public void AccessModifier()
        {
            Console.WriteLine("This is a Public Access Modifier");

            PrivateAccessModifier privateaccessmodifier = new PrivateAccessModifier();
            privateaccessmodifier.Intro();
        }
    }
}
