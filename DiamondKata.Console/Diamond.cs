namespace DiamondKata.Console
{
    public static class Diamond
    {
        public static string Create(string[] args)
        {
            var midpoint = args[0][0];

            if(midpoint == 'A')
            {
                return "A";
            }

            return "AB";
        }
    }
}
