using Study.IBLL;
using Study.IDAL;
using Study.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.BLL
{
    public partial class CourseService : BaseService<Course>, ICourseService
    {
        private ICourseDAL StaffDAL = DALContainer.Container.Resolve<ICourseDAL>();
        public override void SetDal()
        {
            Dal = StaffDAL;
        }
    }
}
