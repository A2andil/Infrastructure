using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Course : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string PictureUrl { get; set; }

        public int Price { get; set; }

        public DateTime Created { get; set; }

        public CourseType CourseType { get; set; }

        public int CourseTypeId { get; set; }

    }
}
