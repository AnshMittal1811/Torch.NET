// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Allows the model to jointly attend to information
            ///	from different representation subspaces.<br></br>
            ///	
            ///	See reference: Attention Is All You Need
            ///	
            ///	\[\text{MultiHead}(Q, K, V) = \text{Concat}(head_1,\dots,head_h)W^O
            ///	\text{where} head_i = \text{Attention}(QW_i^Q, KW_i^K, VW_i^V)
            ///	
            ///	\]
            /// </summary>
            public partial class MultiheadAttention : Module
            {
                // auto-generated class
                
                public MultiheadAttention(PyObject pyobj) : base(pyobj) { }
                
                public MultiheadAttention(Module other) : base(other.PyObject as PyObject) { }
                
                public MultiheadAttention(int embed_dim, int num_heads)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        embed_dim,
                        num_heads,
                    });
                    var kwargs=new PyDict();
                    dynamic py = __self__.InvokeMethod("MultiheadAttention", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
