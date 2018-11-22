using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) { 
        using (var context = new StuContext.StuDBcontext())
        {
            var depts = context.DepartMents.ToList();

            DropDownList1.DataSource = depts;
            DropDownList1.DataTextField = "name";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();

            GridView1.DataSource = context.Students.Select(n => new { Stuno = n.StudentNo, FullName = n.FullName, Department = n.DepartMent.Name, Sex = n.Sex ? "男" : "女", Address = n.Address, Telephone = n.Phone });
            GridView1.DataBind();

        }
    }
    }


    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //    if (TextBox1.Text == "admin")
    //    {
    //        if (TextBox2.Text == "123456")
    //            Response.Write("<script>alert('登入成功！');location.href='default.aspx'</script>");
    //        else
    //            Response.Write("<script>alert('密码不正确！');</script>");
    //    }
    //    else
    //    {
    //        Response.Write("<script>alert('用户名不正确！');</script>");
    //    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //读出选择的部门id
        var id = Guid.Parse(DropDownList1.SelectedIndex);
        //按部门查询学生信息
        using (var context = new StuContext.StuDBcontext())
        {
            var list = context.Students.Where(n => n.DepartMent.ID == id).Select(n => new { Stuno = n.StudentNo, FullName = n.FullName, Department = n.DepartMent.Name, Sex = n.Sex ? "男" : "女", Address = n.Address, Telephone = n.Phone }).OrderBy(x => x.Stuno).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

    }
}