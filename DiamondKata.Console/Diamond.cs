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

            //top half
            for(char i = 'A'; i <= midPoint; i++)
            {
                var space = new string(' ', midPoint - i);

                if (i == 'A')
                {
                    diamond.Append($"{space}{i}{space}");
                    diamond.Append("\n");
                }
                else
                {
                    var index = i - 'A';
                    var spaceBetween = new string(' ', 2 * index - 1);

                    diamond.Append($"{space}{i}{spaceBetween}{i}{space}");
                    diamond.Append("\n");
                }
            }

            //bottom half
            for(char i = midPoint; i >= 'A'; i--)
            {
                if (i == midPoint)
                {
                    continue;
                }

                var space = new string(' ', midPoint - i);

                if (i == 'A') 
                {
                    diamond.Append($"{space}{i}{space}");
                    diamond.Append("\n");
                }
                else
                {
                    var index = i - 'A';
                    var spaceBetween = new string(' ', 2 * index - 1);

                    diamond.Append($"{space}{i}{spaceBetween}{i}{space}");
                    diamond.Append("\n");
                }
            }


            return diamond.ToString();
        }
    }
}
