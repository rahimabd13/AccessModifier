using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    public class PrivateAccessModifier
    {
        //It restricate other program part from accessing its types and its member
        private void IntroOfPrivateModifier()
        {
            Console.WriteLine("This is a Private AccessModifier");
        }
        public void Intro()
        {
            IntroOfPrivateModifier();
        }
    }
}
