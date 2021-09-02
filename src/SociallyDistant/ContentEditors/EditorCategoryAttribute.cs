﻿using System;

namespace SociallyDistant.Core.ContentEditors
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class EditorCategoryAttribute : Attribute
    {
        public string Category { get; }

        public EditorCategoryAttribute(string category)
        {
            Category = category;
        }
    }
}