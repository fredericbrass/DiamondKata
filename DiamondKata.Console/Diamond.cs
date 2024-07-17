using System.Text;

namespace DiamondKata.Console
{
    public static class Diamond
    {
        public static string Create(string[] args)
        {
            var midPoint = args[0][0];
            var diamond = new StringBuilder();

            for(var i = 'A'; i <= midPoint; i++)
            {
                if(i == 'A')
                {
                    diamond.Append(i);
                    diamond.Append("\n");
                }
                else
                {
                    diamond.Append($"{i}{i}");
                    diamond.Append("\n");
                }
            }

            return diamond.ToString();
        }
    }
}
