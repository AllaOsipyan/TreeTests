using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System.Drawing;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new TreeAlgorithm();
            var random = new Random();
            /*  for (int i = 0; i < 26; i++)
              {
                  var node = random.Next(1, 100);
                  if (tree.FindKey(node) == null)
                      tree.Add(node);
              }*/

            tree.Add(25);
            tree.Add(8);
            tree.Add(52);
            tree.Add(46);
            tree.Add(22);
            
            tree.Add(78);
           
            PrintOfTree.Print(tree.Root);
            ReverceInput.Input(tree);
            Console.ReadLine();
        }
    }
}
