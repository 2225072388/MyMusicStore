using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.CodeFirstModels
{

    /// <summary>
    /// 学生实体
    /// </summary>
    public class Students
    {
        public Guid ID { get; set; }
        public string StudentCode { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; } = true;
        public DateTime Bithday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual Department Department { get; set; }

        public Students()
        {
            ID = Guid.NewGuid();

        }
    }
}
