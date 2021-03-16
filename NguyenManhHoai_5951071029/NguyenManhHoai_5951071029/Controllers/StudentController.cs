using NguyenManhHoai_5951071029.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NguyenManhHoai_5951071029.Controllers
{
    public class StudentController: ApiController
    {
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfoList = new List<StudentInfo>();
            var StudentInfo = new StudentInfo
            {
                hoTen = "Nguyen Manh Hoai",
                msv = "5951071029",
                ngaySinh ="10/09/2000",
                lop ="Cong Nghe Thong Tin K59"
            };
            studentInfoList.Add(StudentInfo);
            return studentInfoList;
        }
    }
}