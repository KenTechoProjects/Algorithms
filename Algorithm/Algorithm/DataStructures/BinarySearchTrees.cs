using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructures
{
    public class BinarySearchTrees
    {
        public class TreeNode<T> where T : IComparable<T>
        {
            
            public T Value { get; internal set; }
            public TreeNode<T> Left { get;  internal set; }
            public TreeNode<T> Right { get; internal  set; }

            public TreeNode(T node)
            {
                Value = node;
            }

            public void Insert(T newValue)
            {
                int compare = newValue.CompareTo(Value);
                if (compare == 0) return;

                if (compare < 0)
                {
                    if (Left == null)
                        Left = new TreeNode<T>(newValue);
                    else
                        Left.Insert(newValue);

                }
                else
                {
                    if (Right == null)
                        Right = new TreeNode<T>(newValue);
                    else
                        Right.Insert(newValue);
                }
            }
            public TreeNode<T> Get(T value)
            {
                int compare = value.CompareTo(Value);
                if (compare == 0)
                    return this;

                if (compare < 0)
                {
                    if (Left != null)
                        return Left.Get(value);
                }
                else
                {
                    if (Right != null)
                        return Right.Get(value);
                }
                return null;
            }

            public IEnumerable<T> TraverseInOrder()
            {
                var list = new List<T>();
                InnerTravers(list);
                return list;
            }

            private void InnerTravers(List<T> list)
            {
                if (Left != null)
                    Left.InnerTravers(list);

                list.Add(Value);

                if (Right != null)
                    Right.InnerTravers(list);
            }
            public T Min()
            {
                if (Left != null)
                    return Left.Min();
                return Value;
            }
            public T Max()
            {
                if (Right != null)
                    return Right.Max();
                return Value;
            } 

            public   void PrintLeftView()
            {
                
                foreach (var item in Left.TraverseInOrder())
                {
                    
                    Console.Write($"{item} ");
                }
            }
        }

        public class BinarySearchTree<T> where T : IComparable<T>
        {
           
            private TreeNode<T> _root;
            public BinarySearchTree(T value)
            {
               // _root = new TreeNode<T>(value);
            }
            public TreeNode<T>Get(T value)
            {
                return _root?.Get(value);
            }
            public T Min()
            {
                if(_root is null)                
                    throw new InvalidOperationException();
                return _root.Min();
                
            }
            public T MAx()
            {
                if (_root is null)
                    throw new InvalidOperationException();
                return _root.Max();

            }
            public void Insert(T value)
            {
                if (_root is null)
                    _root = new TreeNode<T>(value);
                else
                    _root.Insert(value);
            }
            public IEnumerable<T> TraverseInOrder()
            {
                if (_root != null)
                    return _root.TraverseInOrder();
                return Enumerable.Empty<T>();
            }
            public void PrintLeftView()
            {
                Console.WriteLine("Left Tree Content");
                _root.PrintLeftView();
            }

            public void Remove(T value)
            {
                _root = Remove(_root, value);
            }

            private TreeNode<T> Remove(TreeNode<T> subTreeRoot, T value)
            {
                if (subTreeRoot is null) { return null; }
                int comparedTo = value.CompareTo(subTreeRoot.Value);
                if (comparedTo < 0)
                {
                    subTreeRoot.Left = Remove(subTreeRoot.Left, value);
                }
                else if(comparedTo>0)
                {
                    subTreeRoot.Right = Remove(subTreeRoot.Right, value);

                }
                else
                {
                    if (subTreeRoot.Left == null)
                    {
                        return subTreeRoot.Right;
                    }
                    if(subTreeRoot.Right==null)
                    {
                        return subTreeRoot.Left;
                    }

                    subTreeRoot.Value = subTreeRoot.Right.Min();
                    subTreeRoot.Right = Remove(subTreeRoot.Right, subTreeRoot.Value);

                }
                return subTreeRoot;
            }
        }
    }
}

