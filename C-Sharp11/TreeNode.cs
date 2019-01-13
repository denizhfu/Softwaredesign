using System;
using System.Collections.Generic;

namespace C_Sharp11
{       
    delegate void MyDelegate(string progress);

    public class TreeNode<T>
    {
        public T treeNode;
        public readonly List<TreeNode<T>> allTreeNodes = new List<TreeNode<T>>();
        public TreeNode<T> CreateNode(T newTreeNode)
        {
            TreeNode<T> node = new TreeNode<T>
            {
                treeNode = newTreeNode
            };
            return node;
        }
        public void AppendChild(TreeNode<T> childNode)
        {
            allTreeNodes.Add(childNode);
        }
        public void RemoveChild(TreeNode<T> childNode)
        {
            allTreeNodes.Remove(childNode);
        }
        public void PrintTree(String position= "")
        {   
            Console.WriteLine(position + treeNode);
            foreach (TreeNode<T> childNode in allTreeNodes)
            {
                childNode.PrintTree(position + "*");
            }
        }
        /*public void GetNode(int index){
                //index = Convert.ToInt32(Console.ReadLine());
                var nodeInList = allTreeNodes[index];
                Console.WriteLine(nodeInList);
        } */
        public void ForEach(){
            
        }
    }


}



