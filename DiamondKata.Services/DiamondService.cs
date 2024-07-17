using DiamondKata.Services.Interfaces;
using System.Text;

namespace DiamondKata.Services
{
    public class DiamondService : IDiamondService
    {
        public string Create(string[] args)
        {
            var midPoint = args[0][0];

            if (midPoint == 'A')
            {
                return "A";
            }

            var diamond = new StringBuilder();

            //top half
            for (char i = 'A'; i <= midPoint; i++)
            {
                var line = CreateLine(i, midPoint);
                diamond.Append(line);
                diamond.Append('\n');
            }

            //bottom half
            for (char i = (char)(midPoint - 1); i >= 'A'; i--)
            {
                var line = CreateLine(i, midPoint);
                diamond.Append(line);

                if (i != 'A')
                {
                    diamond.Append('\n');
                }
            }

            return diamond.ToString();
        }

        public string CreateLine(char index, char midPoint)
        {
            var diamondLine = new StringBuilder();
            var space = new string(' ', midPoint - index);

            if (index == 'A')
            {
                diamondLine.Append($"{space}{index}{space}");
            }
            else
            {
                var sizeIndex = index - 'A';
                var spaceBetween = new string(' ', 2 * sizeIndex - 1);

                diamondLine.Append($"{space}{index}{spaceBetween}{index}{space}");
            }

            return diamondLine.ToString();
        }
    }
}
