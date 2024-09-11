
namespace kyuNamespace
{
    class Students
    {
        public void Study()
        {
            Console.WriteLine("I am a student in kyuNamespace");
        }
    }
}

namespace uonNamespace
{
    class Students
    {
        public void Study() // method
        {
            Console.WriteLine("I am a student in uonNamespace");
        }
    }
}

class Program
{
    static void Main() //static method means that it can be accessed without creating an object of the class
    {
        // kyuNamespace
        kyuNamespace.Students kyuStudent = new kyuNamespace.Students();
        kyuStudent.Study();

        // uonNamespace 
        uonNamespace.Students uonStudent = new uonNamespace.Students();
        uonStudent.Study();
    }
}


// Notes:
/*
1. Namespaces are used to organize different classes in different namespaces to avoid name conflicts.
2. The Main can be used to access classes in different namespaces.
*/