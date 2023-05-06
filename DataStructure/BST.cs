using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //二叉树
    class BST<T> where T : IComparable<T>
    {
        class Node
        {
            public T value;
            public Node left;
            public Node right;

            public Node(T value)
            {
                this.value = value;
                left = null;
                right = null;

            }
        }
        /// <summary>
        /// 二叉树
        /// </summary>
        public BST()
        {
            N = 0;
            root = null;

        }
        int N;
        Node root;

        public int Count { get { return N; } }

        public bool IsEmpty { get { return Count == 0; } }
        /// <summary>
        /// 非递归添加
        /// </summary>
        public void Add1(T value)
        {
            Node cur = root;
            Node pre = null;

            if (root == null)
            {
                root = new Node(value);
                N++;
                return;
            }

            if (value.CompareTo(cur.value) == 0)
                return;

            //循环往下遍历，找到符合条件的空节点  获得空节点位置
            while (cur != null)
            {
                pre = cur;
                if (value.CompareTo(cur.value) < 0)
                {
                    cur = cur.left;
                }
                else
                {
                    cur = cur.right;
                }
            }
            //在空节点处生成新节点
            cur = new Node(value);


            //新节点于父节点关联
            if (value.CompareTo(pre.value) < 0)
            {
                pre.left = cur;
            }
            else
            {
                pre.right = cur;
            }
            N++;
        }

        /// <summary>
        /// 递归添加
        /// </summary>
        public void Add2(T value)
        {
            root = Add3(root, value);
        }
        /// <summary>
        /// 递归添加核心方法  
        /// </summary>

        private Node Add3(Node node, T value)
        {
            //递归的出口
            if (node == null)
            {
                N++;
                return new Node(value);
            }
            //递归插入的值和树的左右节点，找到合法的位置
            if (value.CompareTo(node.value) < 0)
            {
                //添加完更新节点
                node.left = Add3(node.left, value);
            }
            else if (value.CompareTo(node.value) > 0)
            {
                //添加完更新节点
                node.right = Add3(node.right, value);
            }
            //返回给上层父节点 保持顺序
            return node;
        }
        /// <summary>
        /// 以node为根的树，是否包含Value
        /// </summary>
        public bool Contains(T value)
        {
            return Contains(root, value);
        }
        /// <summary>
        /// 搜索核心算法 使用递归方法
        /// </summary>

        private bool Contains(Node node, T value)
        {
            //递归的2个停止条件
            if (node == null)

                return false;

            if (node.value.Equals(value))
                return true;
            //--------------------------
            else if (value.CompareTo(node.value) < 0)
            {
                return Contains(node.left, value);
            }
            else
            {
                return Contains(node.right, value);
            }
        }
        /// <summary>
        /// 前序遍历 【中 左 右】
        /// </summary>
        public void PreOrder()
        {
            PreOrder(root);
        }
        //前序遍历核心算法
        private void PreOrder(Node node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.value);

            PreOrder(node.left);
            PreOrder(node.right);

        }
        /// <summary>
        /// 中序遍历 【左 中 右】 
        /// </summary>
        public void InOrder()
        {
            InOrder(root);
        }

        private void InOrder(Node node) 
        {
            if (node == null)
                return;

            InOrder(node.left);
            Console.WriteLine(node.value);
            InOrder(node.right);
        }

        /// <summary>
        /// 后序遍历 【左  右 中】 
        /// </summary>
        public void PostOrder()
        {
            PostOrder(root);
        }

        private void PostOrder(Node node)
        {
            if (node == null)
                return;

            PostOrder(node.left);
         
            PostOrder(node.right);

            Console.WriteLine(node.value);
        }
        /// <summary>
        /// 层序遍历
        /// </summary>
        public void  LeveOrder()
        {
            //队列 先进先出
            Queue<Node> nodes = new Queue<Node>();

            nodes.Enqueue(root);


            while (nodes.Count != 0)
            {
                //父节点出队
                Node cur = nodes.Dequeue();
                Console.WriteLine(cur.value);
                //将同一层次的子节点 加入队列
                if (cur.left != null)
                {
                    nodes.Enqueue(cur.left);
                }

                if (cur.right != null)
                {
                    nodes.Enqueue(cur.right);
                }

            }
        }
        /// <summary>
        /// 查找树的最小值
        /// </summary>
        /// <returns></returns>
        public T Min()
        {
            if (IsEmpty)
                throw new AggregateException("空树！");

            return  Min(root).value;

        }

        private Node Min(Node node)
        {

            if (node.left == null)
            {
                return node;
            }

             return Min(node.left);
        }
        /// <summary>
        /// 查找树的最大值
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            if (IsEmpty)
                throw new AggregateException("空树！");

            return Max(root).value;
        }

        private Node Max(Node node)
        {
            if (node.right == null)
                return node;

            return Max(node.right);
        }

        /// <summary>
        /// 删除最小值
        /// </summary>
        public T RemoveMin()
        {
            T tep= Min();
            root = RemoveMin(root);
            return tep;
        }
        private Node RemoveMin(Node node)
        {
            //递归出口
            if (node.left == null)
            {
                N--;
                return node.right;
            }

            //更新左节点
            node.left = RemoveMin(node.left);
            //目的 返回根节点
            return node;
        }
        /// <summary>
        /// 删除最大值
        /// </summary>
        public T RemoveMax()
        {
            T tep = Max();
            root = RemoveMax(root);
            return tep;
        }
        private Node RemoveMax(Node node)
        {
            //递归出口
            if (node.right == null)
            {
                N--;
                return node.left;
            }
            //更新右节点
            node.right = RemoveMax(node.right);
            //目的 返回根节点
            return node;
        }
        /// <summary>
        /// 递归删除任意元素
        /// </summary>

        public void Remove(T value)
        {
            Remove(root, value);
        }

        private Node Remove(Node node,T value)
        {
            if (node == null)
                return null;

            if (value.CompareTo(node.value)<0)
            {
                node.left = Remove(node.left, value);
                return node;
            }
            else if (value.CompareTo(node.value) > 0)
            {
                node.right = Remove(node.right,value);
                return node;
            }
            // 如果找到要删除的元素
            else// if(value.CompareTo(node.value)==0)
            {
                //要删除的节点只有左孩子
                if (node.right == null)
                {
                    N--;
                    return node.left;
                }
                //要删除的节点只有右孩子
                if (node.left == null)
                {
                    N--;
                    return node.right;
                }

                // 要删除的节点左右都有孩子
                // 找到比待删除节点大的最小节点, 即待删除节点右子树的最小节点
                // 用这个节点顶替待删除节点的位置

                Node NewValue = Min(node.right);
                NewValue.right = RemoveMin(node.right);
                NewValue.left = node.left;

                return NewValue;
            }

        }
        /// <summary>
        /// 遍历树的高度
        /// </summary>
        /// <returns></returns>
        public int MaxHeight()
        {
          return  MaxHeight(root);
        }

        private int MaxHeight(Node node)
        {
            if (node == null)
                return 0;

            int l = MaxHeight(node.left);
            int r = MaxHeight(node.right);

            //从最底层开始累加1
            return Math.Max(l, r) + 1;
        }
    }
}
