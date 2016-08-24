using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Queue_and_Stack
{
    class stack<T>
    {
        public Stack<T> st=new Stack<T>();
        public Queue<T> qu=new Queue<T>(); 

       internal void Add(T item)
        {
           qu.Enqueue(item);
            st.Push(item);
           
        }

        internal void Sil()
        {
            qu.Dequeue();
            st.Pop();
            
        }
    }
}
