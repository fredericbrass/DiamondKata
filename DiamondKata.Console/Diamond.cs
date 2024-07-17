namespace DiamondKata.Console
{
    public static class Diamond
    {
        public static string Create(string[] args)
        {
            var midPoint = args[0][0];
            string diamond = "";

            for(var i = 'A'; i <= midPoint; i++)
            {
                diamond += i;
            }

            return diamond;
        }
    }
}
