using CleanArch.Domin.Interfaces;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepositroy : ICourseRepository
    {
        private BaranameDBContext context;

        public CourseRepositroy(BaranameDBContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context?.Dispose();
        }
    }
}