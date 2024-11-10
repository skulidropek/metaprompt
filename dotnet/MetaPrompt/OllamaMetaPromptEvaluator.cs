﻿using MetaPrompt.Models;
using MetaPrompt.Services.Bases;
using OllamaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPrompt
{
    public class OllamaMetaPromptEvaluator : MetaPromptEvaluator
    {
        public OllamaMetaPromptEvaluator(ConfigModel config, OllamaApiClient ollama) : base(config, new OllamaLLMService(ollama))
        {
        }
    }
}
