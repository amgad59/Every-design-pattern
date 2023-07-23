
using Autofac;
using Bridge_Pattern.Bridge_pattern;

var cb = new ContainerBuilder();
cb.RegisterType<VectorRenderer>().As<IRenderer>();
cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(),
    p.Positional<float>(0)));
using(var r = cb.Build())
{
    var circle = r.Resolve<Circle>(new PositionalParameter(0,5.0f));
    circle.Draw();
    circle.Resize(5);
    circle.Draw();
}