object[] objects = new object[6];
objects[0] = new Base();
objects[1] = new Derived();
objects[2] = "ZetCode";
objects[3] = 12;
objects[4] = 1.4;
objects[5] = null;

for (int i = 0; i < objects.Length; i++)
{
    string s = objects[i] as string;
    Console.Write("{0}:", i);

    if (s != null)
    {
        Console.WriteLine(s);
    }
    else
    {
        Console.WriteLine("not a string");
    }
}

class Base { }
class Derived : Base { }