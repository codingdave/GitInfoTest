namespace B
{
    public static class StaticClassB
    {
        public static string TestVersion => ThisAssembly.Git.Commit;
    }
}
