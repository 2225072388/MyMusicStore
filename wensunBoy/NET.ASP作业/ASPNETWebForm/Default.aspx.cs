using StuContext;
using StuEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //IsPostBack判断页面是加载还是回发，如果不是回发才进行数据初始化
        if (!IsPostBack)

            using (var context = new StuContext.StuDBContext())
            {
                var depts = context.DepartMents.ToList();
                DropDownList1.DataSource = depts;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();

                var list = context.Students.OrderBy(x => x.Department.Name).ThenByDescending(x => x.StudentNo).ToList();
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
        _getData();

    }
    private void _getData()
    {
        using (var context = new StuDBContext())
        {
            //查询出Product数据
            var productList = context.Students.OrderBy(x => x.FullName).ToList();
            GridView1.DataSource = productList;
            GridView1.DataBind();
        }
    }

    protected string GetName(object obj)
    {
        if (obj != null)
            return ((DepartMent)obj).Name;
        return "没有该专业";
    }
    //当下拉选项发生变化，触发的事件
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //读出选择的部门id
        var id = Guid.Parse(DropDownList1.SelectedValue);
        //按部门查询学生信息
        using (var context = new StuContext.StuDBContext())
        {
            var list = context.Students.Where(n => n.Department.ID == id).OrderBy(x => x.Department.Name).ThenByDescending(x => x.StudentNo).ToList();
            //    //选取若干个字段显示
            //    .Select(n => new
            //    {
            //        StuNo = n.StudentNo,
            //        FullName = n.FullName,
            //        Department = n.Department.Name,
            //        Sex = n.Sex ? "男" : "女",
            //        Address = n.Address,
            //        Telphone = n.Phone
            //    }).OrderBy(x => x.StuNo).ToList();
            //GridView1.DataSource = list;
            //GridView1.DataBind();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        _getData();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        var id = Guid.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
        using (var context = new StuDBContext())
        {
            var delWeb = context.Students.Find(id);
            context.Students.Remove(delWeb);
            context.SaveChanges();
        }
        _getData();
    }

    //切换到编辑
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        _getData();

        //查询出所有的专业

        var context = new StuDBContext();
        var departMents = context.DepartMents.ToList();

        //查询出GridView中分类列编辑状态模板中下拉菜单
        var ddl = (DropDownList)GridView1.Rows[e.NewEditIndex].FindControl("DdlDepartMents");
        //下拉数据绑定
        ddl.DataSource = departMents;
        ddl.DataTextField = "Name";
        ddl.DataValueField = "ID";
        ddl.DataBind();
        //选项绑定
        var id = (Guid)GridView1.DataKeys[e.NewEditIndex].Value;
        var student = context.Students.Find(id);
        if (student.ID!= null)
            ddl.SelectedValue = student.ID.ToString();

    }
    //取消编辑
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        _getData();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        var id = Guid.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
        using (var context = new StuDBContext())
        {

            //查询出要修改这条记录
            var p = context.Students.Find(id);
            //读出GridView中用户编辑的字段，给每个允许修改的实体属性赋值
            //获取用户编辑的这一行
            var row = GridView1.Rows[e.RowIndex];
            var studentNo = (row.Cells[0].Controls[0] as TextBox).Text.Trim();
            var fullName = (row.Cells[1].Controls[0] as TextBox).Text.Trim();
            var phone = (row.Cells[2].Controls[0] as TextBox).Text.Trim();
            var ID = Guid.Parse(((DropDownList)row.FindControl("DdlDepartMents")).SelectedValue);
            p.Department = context.DepartMents.Find(ID);

            p.StudentNo = studentNo;
            p.FullName = fullName;
            p.Phone = phone;
            context.SaveChanges();
        }
        GridView1.EditIndex = -1;
        _getData();
    }
}