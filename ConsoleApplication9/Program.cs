using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\我的配置\My Documents\Visual Studio 2015\Projects\ConsoleApplication9\DllDemoOne\bin\Debug\DllDemoOne.dll";
            Assembly assem = Assembly.LoadFile(path);
            Type[] tys = assem.GetTypes();
            int a = 0;
            int b = 0;
            foreach (var ty in tys)
            {
                ConstructorInfo magicConstructor = ty.GetConstructor(new Type[] {a.GetType(),a.GetType()});//获取不带参数的构造函数
                object magicClassObject = magicConstructor.Invoke(new object[] { 2,4});//这里是获取一个类似于类的实例的东东

                //object magicClassObject = Activator.CreateInstance(t);//获取无参数的构造实例还可以通过这样
                MethodInfo mi = ty.GetMethod("Sum");
                if (ty.Name == "ClassDemoTwo")
                {
                    object aa = mi.Invoke(magicClassObject, new object[] { 2, 5 });
                    Console.WriteLine(aa.ToString());
                }
                else
                {
                    object aa = mi.Invoke(magicClassObject, null);
                    Console.WriteLine(aa.ToString());
                }

            }
            Console.ReadKey();
        }
    }
}
