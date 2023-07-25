Console.WriteLine("test");

/*
 * Generic Value Adapter
 * 
 * 
using Adapter_Pattern.Generic_Value_Adapter;

Vector3f u1 = Vector3f.Create(3.5f, 2.2f, 1);
Vector3f u2 = Vector3f.Create(3.5f, 2.2f, 1);
var u3 = u2 + u1;
Console.WriteLine(u3.ToString());

*/
/*
 * Adapter Pattern
 * 
using Adapter_Pattern.Adapter_pattern;

public class Demo
{
    private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
    {
      new VectorRectangle(1, 1, 10, 10),
      new VectorRectangle(3, 3, 6, 6)
    };

    // the interface we have
    public static void DrawPoint(Point p)
    {
        Console.Write(".");
    }

    static void Main(string[] args)
    {
        Draw();
        Draw();
    }

    private static void Draw()
    {
        foreach (var vo in vectorObjects)
        {
            foreach (var line in vo)
            {
                var adapter = new LineToPointAdapter(line);
                foreach(var a in adapter)
                {
                    DrawPoint(a);
                }
                Console.WriteLine();
            }
        }
    }
}
*/