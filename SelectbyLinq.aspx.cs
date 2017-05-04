using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SelectbyLinq : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) return;

       
    }


    private void GetData() {

        DataClassesDataContext db = new DataClassesDataContext();
        var person = from pa in db.Person
                     where pa.Wid.Equals("010100")
                     select pa;

        foreach (var p in person)
        {
            Response.Write(p.Wid);
            Response.Write(p.C_Name);
            Response.Write(p.Birthday);
        }
    }





    protected void Button2_Click(object sender, EventArgs e)
    {
        //update
        DataClassesDataContext db = new DataClassesDataContext();
        Person pa = db.Person.Single( per => per.Wid=="010100") ;
        pa.Birthday = "1990/07/07";
        pa.Cre_Usr = "010100";
        pa.Cre_Date = DateTime.Now;
        db.SubmitChanges();


        GetData();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        GetData();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        //insert
        DataClassesDataContext db = new DataClassesDataContext();
        Person pa = new Person();
        pa.Wid = "A002";
        pa.C_Name = "安德森";
        pa.E_Name = "Anderson";
        pa.Cre_Usr = "010100";
        pa.Cre_Date = DateTime.Now;

        db.Person.InsertOnSubmit(pa);
        db.SubmitChanges();

        //select
        var person = from per in db.Person
                     where per.Wid.Equals("A002")
                     select per;

        foreach (var p in person)
        {
            Response.Write(p.Wid);
            Response.Write(p.C_Name);
            Response.Write(p.Birthday);
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        DataClassesDataContext db = new DataClassesDataContext();
        var person = from p in db.Person where p.Wid.Equals("A002") select p ;
        db.Person.DeleteAllOnSubmit(person);
        db.SubmitChanges();

        //select
        var personR = from per in db.Person
                     where per.Wid.Equals("A002")
                     select per;

        foreach (var p in personR)
        {
            Response.Write(p.Wid);
            Response.Write(p.C_Name);
            Response.Write(p.Birthday);
        }
    }
}