﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specification
{
    public class CourseParams
    {
        private const int MaxSizeSize = 50;

        public int PageIndex { get; set; } = 1;

        private int _PageSize = 6;

        public int PageSize
        {
            get => _PageSize;
            set => _PageSize = (value > MaxSizeSize ? MaxSizeSize : value);
        }

        public int? TypeId { get; set; }

        public string Sort { get; set; }

        public string _search { get; set; }

        public string Search
        {
            get => _search;
            set => _search = value.ToLower();
        }
    }
}
