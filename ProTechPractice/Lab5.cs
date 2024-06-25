using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProTechPractice
{
    internal class Lab5 : Lab4
    {  
        // метод выбора сортирвки
        public static void Choose()
        {
            int choose= 0;
            Console.WriteLine("Выберите Сортивроку\n" +
                                "1. TreeSort\n" +
                                "2. QuickSort");
            choose = int.Parse(Console.ReadLine());
            if (flag)
            {
                switch (choose)
                {
                    case 1:
                        Console.WriteLine(string.Join(" ",TreeSort(Lab1.correctedLetters)));
                        break;
                    case 2:
                        Console.WriteLine(Lab5.QuickSort(Lab1.correctedLetters, 0, Lab1.correctedLetters.Length - 1));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введены неверные символы:");
            }
            flag = true;
        }
        // Сортировка деревом
        public static char[] TreeSort(char[] array)
        {
            var treeNode = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                treeNode.Insert(new TreeNode(array[i]));
            }

            return treeNode.Transform();
        }
       // Быстрая сортировка
        public static char[] QuickSort(char[] array, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j);
            if (i < rightIndex)
                QuickSort(array, i, rightIndex);
            return array;
        }
    }
    // класс Бинарного дерева
    public class TreeNode
    {
        public TreeNode(char data)
        {
            Data = data;
        }

        //данные
        public char Data { get; set; }

        //левая ветка дерева
        public TreeNode Left { get; set; }

        //правая ветка дерева
        public TreeNode Right { get; set; }

        //рекурсивное добавление узла в дерево
        public void Insert(TreeNode node)
        {
            if (node.Data < Data)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Insert(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Insert(node);
                }
            }
        }
        public char[] Transform(List<char> elements = null)
        {
            if (elements == null)
            {
                elements = new List<char>();
            }

            if (Left != null)
            {
                Left.Transform(elements);
            }

            elements.Add(Data);

            if (Right != null)
            {
                Right.Transform(elements);
            }

            return elements.ToArray();
        }
    }
}
