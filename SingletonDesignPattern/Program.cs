public sealed class Singleton
{
    private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
    private Singleton()
    {
    }

    public static Singleton Instance { get
        {
            return instance.Value;
        }
    }

    public void DoSomething()
    { }
}


//Singeton s = Singleton.Instance
//s.DoSomething();