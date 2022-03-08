
using BenchmarkDotNet.Attributes;

public class ListVersusDictionary
{
    private const int NumElements = 1_000;
    private readonly Random _rnd;
    private readonly string[] _keys;
    private readonly List<string> _list;
    private readonly Dictionary<string, string> _dict;

    public ListVersusDictionary() 
    { 
        _rnd = new Random();
        _list = new List<string>();
        _dict = new Dictionary<string, string>();


        _keys = GetKeys(NumElements).ToArray();      
        _list = _keys.ToList();
        _dict = _list.ToDictionary(k => k, v => string.Empty); 
    }
    // list <datatype>
    // dictionary <key, value>

    [Benchmark]

    public string GetValueFromDictionary()
    {
        var key = RandomKey();
      
        return _dict.TryGetValue(key, out string value) ? value : null;
    }

    [Benchmark]

    public string GetValueFromList()
    {
        var key = RandomKey();

        foreach (var elem in _list)
        {
            if(elem == key)
                return elem;
        }
        return null;
    }
    private string RandomKey() 
    {
        var index = _rnd.Next(0, _keys.Length);
        return _keys[index];
    }

    [Benchmark]

    public string GetContainsFromList()
    {
        var key = RandomKey();
      

        return _list.Contains(key) ? "true" : "false"; 
    }
    private IEnumerable<string> GetKeys(int numElements)
    {

        for (int i = 0; i < numElements; i++)
        {
            yield return i.ToString();
        }
        
    }

}