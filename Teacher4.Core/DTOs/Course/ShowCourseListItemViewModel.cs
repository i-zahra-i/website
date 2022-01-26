using System;
using System.Collections.Generic;
using System.Text;

namespace Teacher4.Core.DTOs.Course
{
    public class ShowCourseListItemViewModel
    {

        public int CourseId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
