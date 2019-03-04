using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_Task04
{
    class Model
    {
        delegate double Operation(double a, double b);

        Dictionary<string, Operation> operations = new Dictionary<string, Operation>()
                                                        { {"+", (a, b) => a + b },
                                                          {"-", (a, b) => a - b },
                                                          {"*", (a, b) => a * b },
                                                          {"/", (a, b) => { if (b == 0)
                                                                                return 0;
                                                                            return a / b;
                                                                           }
                                                          }
                                                        };

        public double PerformOperation(string op, double a, double b)
        {
            if (!operations.ContainsKey(op))
                throw new ArgumentException($"Operation {op} is not found");
            return operations[op](a, b);
        }
    }
}
