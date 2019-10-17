using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        SubsystemA a = new SubsystemA();
        SubsystemB b = new SubsystemB();
        SubsystemC c = new SubsystemC();
        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
                              a.OperationA1() +
                              a.OperationA2() +
                              b.OperationB1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
                              b.OperationB2() +
                              c.OperationC1() +
                              c.OperationC2());
        }
    }
}
