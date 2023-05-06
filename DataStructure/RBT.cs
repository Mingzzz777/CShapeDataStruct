using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{/// <summary>
/// 红黑树
/// </summary>

    class RBT<T> where T : IComparable<T>
    {
        private const bool Red = true;
        private const bool Black = false;

        class Node
        {
            public T value;

            public Node left;
            public Node right;

            public bool color;

            public Node(T value)
            {
                this.value = value;
                this.left = null;
                this.right = null;
                color = Red;
            }
        }



        public RBT()
        {
            N = 0;
            root = null;
        }
        int N;
        Node root;

        public int Count { get { return N; } }

        public bool IsEmpty { get { return Count == 0; } }

        private bool IsRed(Node node)
        {
            if (node == null)
                return Black;

            return node.color;
        }
        /// <summary>
        /// 左旋转 保持红黑树平衡
        /// </summary>
        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            node.right = x.left;
            x.left = node;
            x.color = node.color;
            node.color = Red;
            //返回新的根节点
            return x;
        }
        /// <summary>
        /// 子节点和父节点 颜色翻转
        /// </summary>
        private void FlicpColor(Node node)
        {
            node.color = Red;
            node.left.color = Black;
            node.right.color = Black;
        }
        /// <summary>
        /// 右旋转 保持红黑树平衡
        /// </summary>
        private Node RightRotate(Node node)
        {
            Node x = node.left;
            node.left = x.right;
            x.right = node;
            x.color = node.color;
            node.color = Red;
            //返回新的根节点
            return x;
        }
        /// <summary>
        /// 红黑树的添加方法，基于二叉树
        /// </summary>

        public void Add(T value)
        {
            root = Add(root, value);
            root.color = Black;
        }
        //核心方法
        private Node Add(Node node, T value)
        {
            if (node == null)
            {
                N++;
                return new Node(value);
            }


            if (value.CompareTo(node.value) < 0)
            {
               node.left= Add(node.left, value);
            } 
            else if (value.CompareTo(node.value) > 0)
            {
              node.right= Add(node.right, value);
            }

            //添加节点后 的第一种情况：左黑 右红 左旋转
            if (IsRed(node.right) && !IsRed(node.left))
            {
                //返回父节点 再进行判断 
               node= LeftRotate(node);
            }
            //添加节点后 的第二种情况：左红 右红 颜色翻转
            if (IsRed(node.left) && IsRed(node.right))
            {
                //返回父节点 再进行判断 
                FlicpColor(node);
            }
            //添加节点后 的第三种情况：左黑 左左黑 右旋转
            if (IsRed(node.left) && IsRed(node.left.left))
            {
                //返回父节点 再进行判断 
              node= RightRotate(node);
            }
          
            return node;
        }


        public int MaxHeight()
        {
            return MaxHeight(root);
        }

        private int MaxHeight(Node node)
        {
            if (node == null)
                return 0;

            int left = MaxHeight(node.left);
            int right = MaxHeight(node.right);

            return Math.Max(left, right) + 1;
        }
    }
}
