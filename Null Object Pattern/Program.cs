/*
 * Null object example
 * 
 * 
using Autofac;
using Null_Object_Pattern.Null_Object_Pattern;
using Null_Object_Pattern.Null_Object_Pattern.Interfaces;

var cb = new ContainerBuilder();
cb.RegisterType<BankAccount>();
cb.RegisterType<NullLog>().As<ILog>();

using (var c = cb.Build())
{
    var ba = c.Resolve<BankAccount>();
    ba.Deposit(500);
}*/