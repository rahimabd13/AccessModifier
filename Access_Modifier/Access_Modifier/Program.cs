using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
    public class Program:ProtectedAccessModifier
    {
        static void Main(string[] args)
        {
            PublicAccessModifier publicaccessmodifier = new PublicAccessModifier();
            publicaccessmodifier.AccessModifier();

            PrivateAccessModifier privateaccessmodifier = new PrivateAccessModifier();
            privateaccessmodifier.Intro();

            ProtectedAccessModifier protectedaccessmodifier = new ProtectedAccessModifier();
            Program program = new Program();
            program.IntroOfProtectedModifier();

            InternalAccessModifier internalaccessmodifier = new InternalAccessModifier();
            internalaccessmodifier.IntroOfInternalModifier();
        }
    }
}
