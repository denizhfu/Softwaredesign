﻿using System;

namespace C_Sharp11
{
    class Program
    {
        static void Main(string[] args)
        {

            var tree = new TreeNode<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child2");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree();
            Calculator calc = new Calculator();
            calc.CalculateSomething();

            /*Console.WriteLine("search for node position? Enter position-number : ");
            var userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput > 0){tree.GetNode(userinput);} */

        }

    }
}
