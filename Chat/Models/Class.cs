namespace Chat.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


public class TestEnumerator
{
    private int _veces;
    public TestEnumerator(int veces) { _veces = veces; }
    public object Current { get { return "Hola " + _veces; } }
    public bool MoveNext() { return _veces-- > 0; }
}

public class Test
{
    public TestEnumerator GetEnumerator() { return new TestEnumerator(10); }
}

}