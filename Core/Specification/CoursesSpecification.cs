using Core.Entities;

namespace Core.Specification
{
    public class CoursesSpecification : BaseSpecification<Course>
    {
        public CoursesSpecification(CourseParams courseParams) : base(x =>
        (string.IsNullOrEmpty(courseParams.Search) 
        || x.Name.ToLower().Contains(courseParams.Search))
           && (!courseParams.TypeId.HasValue || x.CourseTypeId == courseParams.TypeId))
        {
            AddInclude(x => x.CourseType);
            ApplyPaging(courseParams.PageSize * (courseParams.PageIndex - 1), courseParams.PageSize);

            if (!string.IsNullOrEmpty(courseParams.Sort))
            {
                switch (courseParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(x => x.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(x => x.Price);
                        break;
                    default:
                        AddOrderBy(x => x.Name);
                        break;
                }
            }
        }

        public CoursesSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.CourseType);
        }
    }
}
