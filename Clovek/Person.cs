using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

public class Person
{
    public string Jmeno { get; private set; }
    public int Vek { get; private set; }

    public Person(string jmeno, int vek)
    {
        Jmeno = jmeno;
        Vek = vek;
    }

    public void Starnout(int roky)
    {
        Vek += roky;
    }
}
