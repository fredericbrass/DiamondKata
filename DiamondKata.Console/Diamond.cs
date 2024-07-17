using System.Text;

namespace DiamondKata.Console
{
    public static class Diamond
    {
        public static string Create(string[] args)
        {
            var midPoint = args[0][0];
            
            if(midPoint == 'A')
            {
                return "A";
            }

            var diamond = new StringBuilder();

            for(var i = 'A'; i <= midPoint; i++)
            {
                var space = new string(' ', midPoint - i);

                if (i == 'A')
                {
                    diamond.Append($"{space}{i}{space}");
                    diamond.Append("\n");
                }
                else
                {
                    diamond.Append($"{space}{i}{i}{space}");
                    diamond.Append("\n");
                }
            }

            return diamond.ToString();
        }
    }
}
