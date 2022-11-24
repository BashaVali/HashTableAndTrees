using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Hash Table And Tree ");
            Console.WriteLine("1.Inserion Binary Search Tree");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> binarySearchTree = new BST<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}