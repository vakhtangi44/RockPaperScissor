public static partial class Outcomes
{
    public static Dictionary<Configuration, Configuration> outcomes = new Dictionary<Configuration, Configuration>()
        {
        {Configuration.paper,Configuration.rock },
        {Configuration.scissors, Configuration.paper },
        {Configuration.rock,Configuration.scissors },
        
        };
}
