using Microsoft.Extensions.DependencyInjection;
using Microsoft.TeamFoundation.Common.Internal;
using System;
using System.Linq.Expressions;

namespace ExpressionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTokenServices();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var tokenService = serviceProvider.GetService<ITokenService>();

            tokenService.GetAll();
            
            //var root = new TreeNode<string>("root");
            //{
            //    var node0 = root.AddChild("node0");
            //    var node1 = root.AddChild("node1");
            //    var node2 = root.AddChild("node2");
            //    {
            //        var node20 = node2.AddChild(null);
            //        TreeNode<string> node21 = node2.AddChild("node21");
            //        {
            //            TreeNode<string> node210 = node21.AddChild("node210");
            //            TreeNode<string> node211 = node21.AddChild("node211");
            //        }
            //    }
            //    TreeNode<string> node3 = root.AddChild("node3");
            //    {
            //        TreeNode<string> node30 = node3.AddChild("node30");
            //    }
            //}

            //var firstString = " a = ( 10 + 5 ) / 2 ";
            //var secondString = " c = a + 20 ";

            //Console.WriteLine(firstString);
            //Console.WriteLine(secondString);

            Console.ReadKey();
        }
    }
}
