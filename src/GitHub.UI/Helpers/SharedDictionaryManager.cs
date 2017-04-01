﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using GitHub.Helpers;

namespace GitHub.UI.Helpers
{
    public class SharedDictionaryManager : SharedDictionaryManagerBase
    {
        static readonly Dictionary<Uri, ResourceDictionary> resourceDicts = new Dictionary<Uri, ResourceDictionary>();

        Uri sourceUri;
        public new Uri Source
        {
            get { return sourceUri; }
            set
            {
                sourceUri = value;
                ResourceDictionary ret;
                if (resourceDicts.TryGetValue(value, out ret))
                {
                    MergedDictionaries.Add(ret);
                    return;
                }
                base.Source = value;
                resourceDicts.Add(value, this);
            }
        }
    }
}
