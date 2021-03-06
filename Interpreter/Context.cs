﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class Context
    {
        private Dictionary<string, int> _variables;

        public Context()
        {
            _variables = new Dictionary<string, int>();
        }

        // Получение значения переменной по имени
        public int GetVariable(string name)
        {
            return _variables[name];
        }

        public void SetVariable(string name, int value)
        {
            if (_variables.ContainsKey(name))
                _variables[name] = value;
            else 
                _variables.Add(name, value);
        }
    }
}
