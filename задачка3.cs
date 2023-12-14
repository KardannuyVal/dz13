using System;
using System.Reflection;

namespace Refl
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("Refl.dll");

            // Создаем объект
            Refl.Refl obj = new Refl.Refl();

            MethodInfo[] methods = obj.GetType().GetMethods(BindingFlags.Instance);

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}
