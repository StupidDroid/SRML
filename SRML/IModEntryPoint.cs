﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using Sony.NP;

namespace SRML
{
    public interface IModEntryPoint 
    {
        void PreLoad();

        void Load();

        void PostLoad();
    }

    public abstract class ModEntryPoint : IModEntryPoint
    {
        public Harmony HarmonyInstance => HarmonyPatcher.GetInstance();

        public virtual void Load()
        {
        }

        public virtual void PostLoad()
        {
        }

        public virtual void PreLoad()
        {
        }
    }
}
