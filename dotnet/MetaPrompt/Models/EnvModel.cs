﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPrompt.Models
{
    public class EnvModel
    {
        private readonly Dictionary<string, string> _variables;
        private readonly EnvModel _parent;

        public EnvModel(Dictionary<string, string> variables, EnvModel parent = null)
        {
            _variables = variables;
            _parent = parent;
        }

        public void Set(string variable, string value)
        {
            _variables[variable] = value;
        }

        public string Get(string variable)
        {
            if (_variables.ContainsKey(variable))
                return _variables[variable];
            return _parent?.Get(variable);
        }
    }
}