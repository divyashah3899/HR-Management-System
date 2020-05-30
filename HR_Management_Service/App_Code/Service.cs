using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public void addEmployee(string fname, string lname, string contact1, string contact2, string email, string address, DateTime dob, string gender, string designation, string acard, string etype, string workexp)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "INSERT INTO Employee VALUES(@fname,@lname,@contact1,@contact2,@email,@address,@dob,@gender,@designation,@acard,@etype,@workexp)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact1", contact1);
            cmd.Parameters.AddWithValue("@contact2", contact2);     
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@acard", acard);
            cmd.Parameters.AddWithValue("@etype", etype);
            cmd.Parameters.AddWithValue("@workexp", workexp);
            cmd.ExecuteNonQuery();    
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }
    }
    public void updateEmployee(int id, string fname, string lname, string contact1, string contact2, string email, string address, DateTime dob, string gender, string designation, string acard, string etype, string workexp)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "UPDATE Employee SET Fname=@fname,Lname = @lname, ContactNo_1 = @contact1, ContactNo_2 = @contact2, Email = @email, Address = @address, DOB = @dob, Gender = @gender, Designation = @designation, AdharCard = @acard, EmployeeType = @etype, WorkExperience = @workexp WHERE E_Id = @id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@contact1", contact1);
            cmd.Parameters.AddWithValue("@contact2", contact2);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@acard", acard);
            cmd.Parameters.AddWithValue("@etype", etype);
            cmd.Parameters.AddWithValue("@workexp", workexp);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }
    }
    public void deleteEmployee(int id)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "DELETE Employee WHERE E_Id = @id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message, "Error Message");
        }
        finally
        {
            con.Close();
        }
    }
    public int totalEmployee()
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        int count = 0;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "Select COUNT(*) FROM Employee";
            cmd = new SqlCommand(s, con);
            count = (int)cmd.ExecuteScalar();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message, "Error Message");
        }
        finally
        {
            con.Close();
        }
        return count;
    }
    public void addProject(string name, string client, string duration, int manager, string technology, string cost)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "INSERT INTO Project VALUES(@name,@client,@duration,@manager,@technology,@cost)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@manager", manager);
            cmd.Parameters.AddWithValue("@technology", technology);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }
    }
    public void updateProject(int id, string name, string client, string duration, int manager, string technology, string cost)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "UPDATE Project SET Name = @name, Client = @client, Duration = @duration, Manager = @manager, Technology = @technology, Cost = @cost WHERE P_Id = @id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@client", client);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@manager", manager);
            cmd.Parameters.AddWithValue("@technology", technology);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }
    }
    public void deleteProject(int id)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "DELETE Project WHERE P_Id = @id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message, "Error Message");
        }
        finally
        {
            con.Close();
        }
    }
    public void setLeaveStatus(int id, string status)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "UPDATE Leave SET Status = @status WHERE L_Id = @id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message, "Error Message");
        }
        finally
        {
            con.Close();
        }
    }
    public void applyLeave(int id, string fname, string ltype, DateTime sdate, DateTime edate, string reason)
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        string status = "Waiting";
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "INSERT INTO Leave VALUES(@id,@fname,@ltype,@sdate,@edate,@reason,@status)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@ltype", ltype);
            cmd.Parameters.AddWithValue("@sdate", sdate);
            cmd.Parameters.AddWithValue("@edate", edate);
            cmd.Parameters.AddWithValue("@reason", reason);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }

    }
    public int loginEmployee(string username, string password)
    {
        int id = 0;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "SELECT * FROM Employee WHERE Email = @username AND Email = @password";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                id = Convert.ToInt32(sdr["E_Id"]);
                sdr.Close();
            }
            else
            {
                id = 0;
                sdr.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }
        return id;
    }
    public Employee1 showDetails(int id)
    {
        Employee1 e = new Employee1();
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-P1CKDDMB;Initial Catalog=HRMS;Integrated Security=True;Pooling=False");
        SqlCommand cmd;
        try
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            string s = "SELECT * FROM Employee WHERE E_Id = @id";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            e.E_Id = Convert.ToInt32(sdr["E_Id"]);
            e.Fname = sdr["Fname"].ToString();
            e.Lname = sdr["Lname"].ToString();
            e.ContactNo_1 = sdr["ContactNo_1"].ToString();
            e.ContactNo_2 = sdr["ContactNo_2"].ToString();
            e.Email = sdr["Email"].ToString();
            e.Address = sdr["Address"].ToString();
            e.DOB = Convert.ToDateTime(sdr["DOB"]);
            e.Gender = sdr["Gender"].ToString();
            e.Designation = sdr["Designation"].ToString();
            e.AdharCard = sdr["AdharCard"].ToString();
            e.EmployeeType = sdr["EmployeeType"].ToString();
            e.WorkExperience = sdr["WorkExperience"].ToString();
            sdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message, "Error");
        }
        finally
        {
            con.Close();
        }

        return e;
    }
}
